package com.example.robot;

import java.util.Random;

class Robot {
    private int pos_x, pos_y;
    private final World world;
    private final int goal_x, goal_y;
    private static final double SMART_MOVE_PROBABILITY = 0.4;
    private static final char ROBOT_CHAR = 'R';
    private static final char GOAL_CHAR = 'G';
    private static final char INITIAL_GRID_CHAR = '*';
    private static final int NUMBER_OF_DIRECTIONS = 4;

    public Robot(int x, int y, int goalX, int goalY, World world) {
        validatePosition(x, y, world);  // Validate Robot Position
        validatePosition(goalX, goalY, world);  // Validate Goal Position

        this.pos_x = x;
        this.pos_y = y;
        this.world = world;
        this.goal_x = goalX;
        this.goal_y = goalY;

        world.setCharacterAt(x, y, ROBOT_CHAR);
        world.setCharacterAt(goal_x, goal_y, GOAL_CHAR);
    }

    private void validatePosition(int x, int y, World world) {
        if (x < 0 || x >= world.getWidth()) {
            throw new IllegalArgumentException("X position " + x + " is out of bounds (0-" + (world.getWidth() - 1) + ").");
        }
        if (y < 0 || y >= world.getHeight()) {
            throw new IllegalArgumentException("Y position " + y + " is out of bounds (0-" + (world.getHeight() - 1) + ").");
        }
    }

    public void step(Direction direction) {
        world.setCharacterAt(pos_x, pos_y, '*');
        calculateNewPosition(direction);
        world.setCharacterAt(pos_x, pos_y, 'R');
    }

    private void calculateNewPosition(Direction direction) {
        switch (direction) {
            case UP:
                pos_y = (pos_y - 1 + world.getHeight()) % world.getHeight();
                break;
            case DOWN:
                pos_y = (pos_y + 1) % world.getHeight();
                break;
            case LEFT:
                pos_x = (pos_x - 1 + world.getWidth()) % world.getWidth();
                break;
            case RIGHT:
                pos_x = (pos_x + 1) % world.getWidth();
                break;
        }
    }

    public void navigate() {
        Random random = new Random();

        while (goal_x != pos_x || goal_y != pos_y) {
            if (random.nextDouble() < SMART_MOVE_PROBABILITY) {
                // Make a smart move towards the goal
                Direction smartMove = determineSmartMove();
                step(smartMove);
                System.out.print("Smart Move:");
            } else {
                // Make a random move
                int action = random.nextInt(NUMBER_OF_DIRECTIONS);
                step(Direction.values()[action]);
                System.out.print("Random Move:");
            }
            System.out.println(world);
        }
    }
    private Direction determineSmartMove() {
        // Determine the direction that brings the robot closer to its goal
        if (Math.abs(goal_x - pos_x) > Math.abs(goal_y - pos_y)) {
            // Move horizontally
            return (pos_x < goal_x) ? Direction.RIGHT : Direction.LEFT;
        } else {
            // Move vertically
            return (pos_y < goal_y) ? Direction.DOWN : Direction.UP;
        }
    }
}
