package com.example.robot;

class Main {
    public static void main(String[] args) {
        try {
            World world = new World(10);
            Robot robot = new Robot(2, 3, world);
            System.out.print("\nInitial State:");
            System.out.println(world);

            System.out.println("Navigating to goal:");
            robot.navigate();
        } catch (IllegalArgumentException e) {
            System.out.println("Error: " + e.getMessage());
        }
    }
}