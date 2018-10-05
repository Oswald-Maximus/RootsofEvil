using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : BaseMinion {

	public enum Specialisations
	{
		Warrior,
		Mage,
		Rogue,
		Archer
	}
	void Start()
	{
		maxHp = 150;
		hp = 150;
		morale = 1;
		build = 0.1;
		speed = 1;
		def = 1;
		atk = 1;
		range = 1;
	}
}

public void Specialise(Specialisations specialisation)
{

}
