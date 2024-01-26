package com.example.robot;

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
