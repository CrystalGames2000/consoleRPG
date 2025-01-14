﻿public static class Dice
{
    public static int Roll(int faces) {
        Random r = new Random();
        return r.Next(1, faces+1);
    }

    public static int Roll(int faces, int amount) {
        int res = 0;
        Random r = new Random();
        for (int i = 0; i < amount; i++) {
            res += r.Next(1, faces + 1);
        }

        return res;
    }

    public static int Roll(int faces, int amount, int modifier) {
        int res = 0;
        Random r = new Random();
        for (int i = 0; i < amount; i++) {
            res += r.Next(1, faces+1);
        }

        res += modifier;

        return res;
    }
}