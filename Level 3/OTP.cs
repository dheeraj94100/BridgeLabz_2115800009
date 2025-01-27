using System;

public class OTPGenerator
{
    public static Random random = new Random();

    public static void Main(string[] args)
    {
        int[] otpArray = new int[10];

        for (int i = 0; i < 10; i++)
        {
            otpArray[i] = GenerateOTP();
            Console.WriteLine($"Generated OTP {i + 1}: {otpArray[i]}");
        }
        bool areUnique = AreUnique(otpArray);
        Console.WriteLine($"Are all OTPs unique? {areUnique}");
    }

    public static int GenerateOTP()
    {
        return random.Next(100000, 999999);
    }

    public static bool AreUnique(int[] otpArray)
    {
        for (int i = 0; i < otpArray.Length; i++)
        {
            for (int j = i + 1; j < otpArray.Length; j++)
            {
                if (otpArray[i] == otpArray[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}