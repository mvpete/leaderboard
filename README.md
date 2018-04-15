# leaderboard - .NET Core

Leaderboard is a simple .NET Core backed leaderboard app. It has a very basic display page that right now uses 
online hosted bootstrap to theme simple table.

![Demo Image](https://github.com/mvpete/leaderboard/blob/master/Demo/demo.PNG)

The api has 3 simple actions

```
GET /api/leaderboard - retrieve a list of all leaders, ordered by score
GET /api/leaderboard/top/{count} - retrieve {count} of leaders
POST /api/leaderboard - add a new entry
{
 "Name":"GamerTag",
  "Score":12345
}
```
