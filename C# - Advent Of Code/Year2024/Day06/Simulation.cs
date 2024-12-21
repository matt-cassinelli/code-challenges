using AdventOfCode.Shared;

namespace AdventOfCode.Year2024.Day06;

public class Simulation
{
    private readonly Player _player;
    private readonly Dictionary<Point, char> _map;
    private readonly HashSet<Point> _uniquePointsVisited;
    private readonly HashSet<(Point, Direction)> _stateSnapshots;

    public Simulation(Dictionary<Point, char> map)
    {
        _map = map;
        _player = new Player(map);
        _uniquePointsVisited = [];
        _stateSnapshots = [];
    }

    public static Simulation FromMap(Dictionary<Point, char> map) => new(map);

    public SimulationResult Run()
    {
        while (true)
        {
            if (PlayerIsOutsideOfMap())
                return new SimulationResult(_uniquePointsVisited.Count, false);

            if (!_uniquePointsVisited.Contains(_player.Position))
                _uniquePointsVisited.Add(_player.Position);

            if (PlayerIsLookingAtObstacle())
            {
                if (PlayerIsInALoop()) // To improve performance, we can check this just near obstacles.
                    return new SimulationResult(_uniquePointsVisited.Count, true);

                _stateSnapshots.Add((_player.Position, _player.Direction));
                _player.Rotate90();
                continue;
            }
                
            _player.MoveOneStep();
        }
    }

    private bool PlayerIsOutsideOfMap() =>
        !_map.ContainsKey(_player.Position);

    private bool PlayerIsLookingAtObstacle() =>
        _map.TryGetValue(_player.LookingAt(), out var charInFrontOfPlayer) && charInFrontOfPlayer == '#';

    private bool PlayerIsInALoop() =>
        _stateSnapshots.Contains((_player.Position, _player.Direction));
}

public record SimulationResult(int VisitedPoints, bool IsLoop);
