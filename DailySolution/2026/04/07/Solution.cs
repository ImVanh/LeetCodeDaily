namespace LeetCodeDaily20260407;
public class Robot {

    private int width;
    private int height;
    private int x;
    private int y;
    private string direction;
    private int size;
    private int temp;

    public Robot(int width, int height) {
        this.width = width;
        this.height = height;
        size = width * height;
        this.x = 0;
        this.y = 0;
        this.direction = "East";
        temp = 0;
    }

    public void Step(int num) {
        temp += num;
    }

    public void Move(int num) {
        num = num % size;
        for (int i = 0; i < num; i++) {
            switch (direction) {
                case "East":
                    if (x == width - 1) {
                        direction = "North";
                        y = y + 1;
                        continue;
                    }
                    x = x + 1;
                    continue;
                case "North":
                    if (y == height - 1) {
                        direction = "West";
                        x = x - 1;
                        continue;
                    }
                    y = y + 1;
                    continue;
                case "South":
                    if (y == 0) {
                        direction = "East";
                        x = x + 1;
                        continue;
                    }
                    y = y - 1;
                    continue;
                case "West":
                    if (x == 0) {
                        direction = "South";
                        y = y - 1;
                        continue;
                    }
                    x = x - 1;
                    continue;
            }
        }
    }

    public int[] GetPos() {
        Move(temp);
        temp = 0;
        return new int[] { x, y };
    }

    public string GetDir() {
        Move(temp);
        temp = 0;
        return direction;
    }
}
