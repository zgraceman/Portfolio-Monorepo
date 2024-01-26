package com.example.robot;

import java.util.Random;

class Robot {
    private int pos_x, pos_y;
    private World world;
    private int goal_x, goal_y;

    public Robot(int x, int y, World world) {
        validatePosition(x, y, world);
        this.pos_x = x;
        this.pos_y = y;
        this.world = world;
        this.goal_x = world.getSize() - 1;
        this.goal_y = world.getSize() - 1;
        world.setCharacterAt(x, y, 'R');
        world.setCharacterAt(goal_x, goal_y, 'G');
    }

    private void validatePosition(int x, int y, World world) {
        if (x < 0 || x >= world.getSize() || y < 0 || y >= world.getSize()) {
            throw new IllegalArgumentException("Initial robot position out of bounds");
        }
    }

    public void step(Direction direction) {
        world.setCharacterAt(pos_x, pos_y, '*');
        switch (direction) {
            case UP:
                if (pos_y > 0) pos_y--;
                break;
            case DOWN:
                if (pos_y < world.getSize() - 1) pos_y++;
                break;
            case LEFT:
                if (pos_x > 0) pos_x--;
                break;
            case RIGHT:
                if (pos_x < world.getSize() - 1) pos_x++;
                break;
        }
        world.setCharacterAt(pos_x, pos_y, 'R');
    }

    public void navigate() {
        Random random = new Random();
        while (goal_x != pos_x || goal_y != pos_y) {
            int action = random.nextInt(4);
            step(Direction.values()[action]);
            System.out.println(world);
        }
    }
}
