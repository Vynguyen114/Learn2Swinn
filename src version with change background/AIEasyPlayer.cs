using System;

/// <summary>
/// The AIEasyPlayer is an AI that just shoots randomly in the battlefield
/// </summary>
public class AIEasyPlayer : AIPlayer
{
    public AIEasyPlayer(BattleShipsGame controller) : base(controller)
    {
    }
    private enum AIStates
    {
        Searching,
        TargetingShip
    }

    private AIStates _CurrentState = AIStates.Searching;
    /// <summary>
    /// GenerateCoordinates should generate random shooting coordinates
    /// only when it has not found a ship, or has destroyed a ship and
    /// needs new shooting coordinates
    /// </summary>
    /// <param name="row">the generated row</param>
    /// <param name="column">the generated column</param>
    private void SearchCoords(ref int row, ref int column)
    {
        row = Convert.ToInt32(_Random.Next(0, EnemyGrid.Height));
        column = Convert.ToInt32(_Random.Next(0, EnemyGrid.Width));
    }   
    protected override void ProcessShot(int row, int col, AttackResult result)
    {

        if (result.Value == ResultOfAttack.Hit){ }
        else if (result.Value == ResultOfAttack.ShotAlready)
        {
            throw (new ApplicationException("Error in AI"));
        }
    }
    /// <summary>
    /// GenerateCoordinates generates random coordinates
    /// when it has not found a ship or has destroyed a ship
    /// needs new shooting coordinates
    /// </summary>
    /// <param name="row">the generated row</param>
    /// <param name="column">the generated column</param>
    protected override void GenerateCoords(ref int row, ref int column)
    {
        do
        {
            switch (_CurrentState)
            {
                case AIStates.Searching:
                    SearchCoords(ref row, ref column);
                    break;
                default:
                    throw (new ApplicationException("AI has gone in an imvalid state"));
            }
        } while (row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid.Item(row, column) != TileView.Sea); //while inside the grid and not a sea tile do the search
    }
}