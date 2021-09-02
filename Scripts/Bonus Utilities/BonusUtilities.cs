﻿using System;

[Flags]
public enum BonusType {
	None,
	DestroyWholeRowColumn
}

public enum GameState {
	None,
	SelectionStarted,
	Animating
}

public static class BonusTypeChecker {

	public static bool ContaintsDestroyWholeRowColumn(BonusType bt) {
		return (bt & BonusType.DestroyWholeRowColumn) == BonusType.DestroyWholeRowColumn;
//		return bt == BonusType.DestroyWholeRowColumn;
	}

}
