/*
Exceding core requirements:
Includes a levelling system to enhance user motivation (inside GoalManager):
- GetLevel(): player levels up based on total score.
- GetRankTitle(): rank titles are assigned when appropriate.
- Levels and ranks are displayed in the goal list.
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
