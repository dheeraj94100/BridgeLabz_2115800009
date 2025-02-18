using System;
using System.Collections.Generic;

// Define the IMealPlan interface
public interface IMealPlan
{
    string GetMealDetails();
}

// Implement VegetarianMeal class
public class VegetarianMeal : IMealPlan
{
    public string GetMealDetails()
    {
        return "Vegetarian Meal: Includes vegetables, fruits, grains, and dairy.";
    }
}

// Implement VeganMeal class
public class VeganMeal : IMealPlan
{
    public string GetMealDetails()
    {
        return "Vegan Meal: Includes vegetables, fruits, grains, and no animal products.";
    }
}

// Implement KetoMeal class
public class KetoMeal : IMealPlan
{
    public string GetMealDetails()
    {
        return "Keto Meal: Includes high-fat, low-carb foods.";
    }
}

// Implement HighProteinMeal class
public class HighProteinMeal : IMealPlan
{
    public string GetMealDetails()
    {
        return "High-Protein Meal: Includes foods rich in protein.";
    }
}

// Define the generic Meal class
public class Meal<T> where T : IMealPlan, new()
{
    private T mealPlan;

    public Meal()
    {
        mealPlan = new T();
    }

    public string GetMealPlanDetails()
    {
        return mealPlan.GetMealDetails();
    }
}

// Define a class to generate meal plans
public static class MealPlanGenerator
{
    public static void GenerateMealPlan<T>() where T : IMealPlan, new()
    {
        Meal<T> meal = new Meal<T>();
        Console.WriteLine(meal.GetMealPlanDetails());
    }
}

// Main class to test the implementation
public class PersonalizedMealPlanGenerator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose a meal plan: 1. Vegetarian 2. Vegan 3. Keto 4. High-Protein");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                MealPlanGenerator.GenerateMealPlan<VegetarianMeal>();
                break;
            case 2:
                MealPlanGenerator.GenerateMealPlan<VeganMeal>();
                break;
            case 3:
                MealPlanGenerator.GenerateMealPlan<KetoMeal>();
                break;
            case 4:
                MealPlanGenerator.GenerateMealPlan<HighProteinMeal>();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}