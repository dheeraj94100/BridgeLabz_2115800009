using System;
using System.IO;

class ByteArrayStream
{
    static void Main(string[] args)
    {
        string inputImagePath = "image.jpg";
        string outputImagePath = "image1.jpg";

        try
        {
            // Convert image to byte array
            byte[] imageBytes = File.ReadAllBytes(inputImagePath);

            // Write byte array to new image file
            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
            {
                File.WriteAllBytes(outputImagePath, memoryStream.ToArray());
            }

            // Verify that the new file is identical to the original image
            byte[] originalImageBytes = File.ReadAllBytes(inputImagePath);
            byte[] newImageBytes = File.ReadAllBytes(outputImagePath);

            bool isIdentical = CompareByteArrays(originalImageBytes, newImageBytes);
            Console.WriteLine("The new image file is identical to the original: " + isIdentical);
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static bool CompareByteArrays(byte[] array1, byte[] array2)
    {
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }

        return true;
    }
}