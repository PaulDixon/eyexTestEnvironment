﻿using UnityEngine;
using System.Collections;

abstract public class state <T> {
	abstract public void Enter (T entity);
	abstract public void Execute (T entity);
	abstract public void Exit(T entity);
}
