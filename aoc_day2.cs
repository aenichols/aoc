namespace aoc.day.two;

// create submarine class with properties depth, and horizontal
public class Submarine
{
    private int _depth;
    private int _horizontal;
    private int _aim;

    public Submarine() { }

    private  void MoveDepth(int depth)
    {
        _depth += depth;
    }

    private void MoveHorizontal(int horizontal)
    {
        _horizontal += horizontal;
    }

    private void MoveAim(int aim)
    {
        _aim += aim;
    }

    public (int depth, int horizontal, int aim) GetPosition()
    {
        return (_depth, _horizontal, _aim);
    }

    public void CommandSub(Commands command, int inc)
    {
        switch (command)
        {
            case Commands.up:
                MoveDepth(-Math.Abs(inc));
                break;
            case Commands.down:
                MoveDepth(inc);
                break;
            case Commands.forward:
                MoveHorizontal(inc);
                break;
            default:
                break;
        }
    }

    public void CommandSub_two(Commands command, int inc)
    {
        switch (command)
        {
            case Commands.up:
                MoveAim(-Math.Abs(inc));
                //MoveDepth(-Math.Abs(inc));
                break;
            case Commands.down:
                MoveAim(inc);
                //MoveDepth(inc);
                break;
            case Commands.forward:
                MoveHorizontal(inc);
                MoveDepth(_aim * inc);
                break;
            default:
                break;
        }
    }
}

public enum Commands
{
  forward,
  down,
  up
}
