using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMinion : MonoBehaviour {

#region Stats
public int maxHp;
public int hp;
public double morale;
public double atk;
public double build;
public double speed;
public double def;
public bool friendly;
public int range;
public TileClass currentTile;
#endregion
	
#region Functions
public void Build()
{

}
public void Patrol()
{

}
public void Attack()
{

}
public void Flee()
{

}
public void Die()
{
	//death animation goes here
	Destroy(gameObject);
}
public void MoraleChange(int change)
{
	morale += change;
}
public void rest()
{
	hp++;
}
public void MoraleDecay()
{

}
public void Pathfinding()
{
	int modC = 1;
	int maxMod = 100;
	int threshold = 0;
	TileClass target = null;
	Recursion: modC++;
	for (int mod = 0; mod <= modC; mod++)
	{
		if (currentTile.GetTileAt(new Vector2(currentTile.position.x + modC, currentTile.position.y + mod)).priority > threshold)
		{
			target = currentTile.GetTileAt(new Vector2(currentTile.position.x + modC, currentTile.position.y + mod));
			threshold = target.priority;
			maxMod = modC*2;
		}
		if (currentTile.GetTileAt(new Vector2(currentTile.position.x + modC, currentTile.position.y - mod)).priority > threshold)
		{
			target = currentTile.GetTileAt(new Vector2(currentTile.position.x + modC, currentTile.position.y - mod));
			threshold = target.priority;
			maxMod = modC*2;
		}
		if (currentTile.GetTileAt(new Vector2(currentTile.position.x + mod, currentTile.position.y - modC)).priority > threshold)
		{
			target = currentTile.GetTileAt(new Vector2(currentTile.position.x + mod, currentTile.position.y - modC));
			threshold = target.priority;
			maxMod = modC*2;
		}
		if (currentTile.GetTileAt(new Vector2(currentTile.position.x - mod, currentTile.position.y + modC)).priority > threshold)
		{
			target = currentTile.GetTileAt(new Vector2(currentTile.position.x - mod, currentTile.position.y + modC));
			threshold = target.priority;
			maxMod = modC*2;
		}
	}
	if (threshold == currentTile.noOfPriorityLevels || modC == maxMod)
	{
		Pathfinding(target);
	}
	else
	{
		goto Recursion;
	}
}
public void Pathfinding(TileClass target)
{

}
#endregion
}
