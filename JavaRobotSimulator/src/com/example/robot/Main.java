package com.example.robot;

class Main {
    public static void main(String[] args) {
        try {
            World world = new World(10);
            Robot robot = new Robot(2, 3, world);
            System.out.println("Initial State:");
            System.out.println(world);

            for (int i = 0; i < 5; i++) {
                robot.step(Direction.UP);
                System.out.println("After step UP:");
                System.out.println(world);
            }

            System.out.println("Navigating to goal:");
            robot.navigate();
        } catch (IllegalArgumentException e) {
            System.out.println("Error: " + e.getMessage());
        }
    }
}