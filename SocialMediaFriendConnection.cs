using System;
using System.Collections.Generic;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> FriendIds { get; set; }

    public User(int userId, string name, int age)
    {
        UserId = userId;
        Name = name;
        Age = age;
        FriendIds = new List<int>();
    }
}

public class SocialMediaFriendConnection
{
    private class Node
    {
        public User User { get; set; }
        public Node Next { get; set; }

        public Node(User user)
        {
            User = user;
            Next = null;
        }
    }

    private Node head;

    public void AddUser(User user)
    {
        Node newNode = new Node(user);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void AddFriendConnection(int userId1, int userId2)
    {
        User user1 = FindUserById(userId1);
        User user2 = FindUserById(userId2);

        if (user1 != null && user2 != null)
        {
            user1.FriendIds.Add(userId2);
            user2.FriendIds.Add(userId1);
        }
    }

    public void RemoveFriendConnection(int userId1, int userId2)
    {
        User user1 = FindUserById(userId1);
        User user2 = FindUserById(userId2);

        if (user1 != null && user2 != null)
        {
            user1.FriendIds.Remove(userId2);
            user2.FriendIds.Remove(userId1);
        }
    }

    public List<int> FindMutualFriends(int userId1, int userId2)
    {
        User user1 = FindUserById(userId1);
        User user2 = FindUserById(userId2);

        if (user1 != null && user2 != null)
        {
            List<int> mutualFriends = new List<int>();
            foreach (int friendId in user1.FriendIds)
            {
                if (user2.FriendIds.Contains(friendId))
                {
                    mutualFriends.Add(friendId);
                }
            }
            return mutualFriends;
        }
        return null;
    }

    public List<int> DisplayAllFriends(int userId)
    {
        User user = FindUserById(userId);
        return user?.FriendIds;
    }

    public User SearchUserByName(string name)
    {
        Node current = head;
        while (current != null)
        {
            if (current.User.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return current.User;
            }
            current = current.Next;
        }
        return null;
    }

    public User SearchUserById(int userId)
    {
        return FindUserById(userId);
    }

    public int CountFriends(int userId)
    {
        User user = FindUserById(userId);
        return user?.FriendIds.Count ?? 0;
    }

    private User FindUserById(int userId)
    {
        Node current = head;
        while (current != null)
        {
            if (current.User.UserId == userId)
            {
                return current.User;
            }
            current = current.Next;
        }
        return null;
    }

    public static void Main(string[] args)
    {
        SocialMediaFriendConnection smfc = new SocialMediaFriendConnection();

        User user1 = new User(1, "Alice", 25);
        User user2 = new User(2, "Bob", 30);
        User user3 = new User(3, "Charlie", 35);

        smfc.AddUser(user1);
        smfc.AddUser(user2);
        smfc.AddUser(user3);

        smfc.AddFriendConnection(1, 2);
        smfc.AddFriendConnection(1, 3);

        Console.WriteLine("Friends of Alice:");
        foreach (var friendId in smfc.DisplayAllFriends(1))
        {
            Console.WriteLine(friendId);
        }

        Console.WriteLine("Mutual friends of Alice and Bob:");
        foreach (var friendId in smfc.FindMutualFriends(1, 2))
        {
            Console.WriteLine(friendId);
        }

        Console.WriteLine("Number of friends of Alice: " + smfc.CountFriends(1));

        User searchedUser = smfc.SearchUserByName("Charlie");
        if (searchedUser != null)
        {
            Console.WriteLine("Found user: " + searchedUser.Name);
        }
    }
}