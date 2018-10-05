using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : BaseMinion {

	void Start()
	{
		maxHp = 100;
		hp = 100;
		morale = 1;
		atk = 0.5;
		build = 1;
		speed = 1;
		def = 0.4;
		range = 1;
	}
}
