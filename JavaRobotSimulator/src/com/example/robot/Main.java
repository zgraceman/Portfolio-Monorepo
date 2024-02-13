package com.example.robot;

import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        try (Scanner scanner = new Scanner(System.in)) {

            System.out.print("Enter world width: ");
            while (!scanner.hasNextInt()) {
                System.out.println("Please enter a valid integer.");
                scanner.next(); // Consume the invalid input
                System.out.print("Enter world width: ");
            }
            int width = scanner.nextInt();


            System.out.print("Enter world height: ");
            while (!scanner.hasNextInt()) {
                System.out.println("Please enter a valid integer.");
                scanner.next(); // Consume the invalid input
                System.out.print("Enter world height: ");
            }
            int height = scanner.nextInt();

            World world = new World(width, height);

            System.out.print("Enter robot's starting X position: ");
            while (!scanner.hasNextInt()) {
                System.out.println("Please enter a valid integer.");
                scanner.next(); // Consume the invalid input
                System.out.print("Enter robot's starting X position: ");
            }
            int startX = scanner.nextInt();

            System.out.print("Enter robot's starting Y position: ");
            while (!scanner.hasNextInt()) {
                System.out.println("Please enter a valid integer.");
                scanner.next(); // Consume the invalid input
                System.out.print("Enter robot's starting Y position: ");
            }
            int startY = scanner.nextInt();

            System.out.print("Enter goal X position: ");
            while (!scanner.hasNextInt()) {
                System.out.println("Please enter a valid integer.");
                scanner.next(); // Consume the invalid input
                System.out.print("Enter goal X position: ");
            }
            int goalX = scanner.nextInt();

            System.out.print("Enter goal Y position: ");
            while (!scanner.hasNextInt()) {
                System.out.println("Please enter a valid integer.");
                scanner.next(); // Consume the invalid input
                System.out.print("Enter goal Y position: ");
            }
            int goalY = scanner.nextInt();

            Robot robot = new Robot(startX, startY, goalX, goalY, world);
            System.out.print("\nInitial State:");
            System.out.println(world);

            System.out.println("Navigating to goal:");
            robot.navigate();
        } catch (IllegalArgumentException e) {
            System.out.println("Error: " + e.getMessage());
        }
    }
}