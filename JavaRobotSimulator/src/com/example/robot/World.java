package com.example.robot;

class World {
    private final int width;
    private final int height;
    private final char[][] grid;
    private static final char INITIAL_GRID_CHAR = '*';

    public World(int width, int height) {
        this.width = width;
        this.height = height;
        this.grid = new char[height][width];
        initializeGrid();
    }

    private void initializeGrid() {
        for (int i = 0; i < height; i++) {
            for (int j = 0; j < width; j++) {
                grid[i][j] = INITIAL_GRID_CHAR;
            }
        }
    }

    public void setCharacterAt(int x, int y, char character) {
        grid[y][x] = character;
    }

    @Override
    public String toString() {
        StringBuilder s = new StringBuilder("\n");
        for (int i = 0; i < height; i++) { // Use height for the outer loop
            for (int j = 0; j < width; j++) { // Use width for the inner loop
                s.append(grid[i][j]).append(' ');
            }
            s.append('\n');
        }
        return s.toString();
    }


}
