import java.util.Random;
enum Direction {
    UP, DOWN, LEFT, RIGHT
}
class World {
    private int size;
    private char[][] grid;

    public World(int size) {
        this.size = size;
        this.grid = new char[size][size];
        initializeGrid();
    }

    public int getSize() {
        return size;
    }

    public void setSize(int size) {
        this.size = size;
    }

    private void initializeGrid() {
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                grid[i][j] = '*';
            }
        }
    }

    public void setCharacterAt(int x, int y, char character) {
        grid[y][x] = character;
    }

    @Override
    public String toString() {
        StringBuilder s = new StringBuilder("\n");
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                s.append(grid[i][j]).append(' ');
            }
            s.append('\n');
        }
        return s.toString();
    }
}

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