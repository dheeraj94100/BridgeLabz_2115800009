namespace MyLibrary
{
    public class ListManager
    {
        public void AddElement(List<int> list, int element)
        {
            list.Add(element);
        }

        public bool RemoveElement(List<int> list, int element)
        {
            return list.Remove(element);
        }

        public int GetSize(List<int> list)
        {
            return list.Count;
        }
    }
}
