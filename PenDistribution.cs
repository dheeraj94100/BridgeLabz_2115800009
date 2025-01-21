using System;

class Level1 {
    static void Main() {
        int totalPens = 14, students = 3;
        int pensPerStudent = totalPens / students;
        int remainingPens = totalPens % students;

        Console.WriteLine($"The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remainingPens}.");
    }
}