using UnityEngine;
using System.Collections;

public class GridPathfinding : MonoBehaviour {

	int height;
	int width;

	static int[,] grid;
	
	void Start () {
		if (grid == null) {
			grid = GetComponent<GridSystem>().GetGrid();
			width = grid.GetLength(0);
			height = grid.GetLength(1);
		}
	}

	bool CanMoveNorth(int x, int y) {
		if (y == 0) {
			return false; // already on top edge
		}
		if (grid [x, y - 1] == 0) {
			return true;
		}
		return false;
	}
	bool CanMoveSouth(int x, int y) {
		if (y == height - 1) {
			return false; // already on bottom edge
		}
		if (grid[x,y+1] == 0) return true;        
		return false;
	}
	bool CanMoveEast(int x, int y) {
		if (x == width - 1) {
			return false; // on right edge
		}
		if (grid [x + 1, y] == 0) {
			return true;
		}
		return false;
	}
	bool CanMoveWest(int x, int y) {
		if (x == 0) {
			return false; // on left edge
		}
		if (grid [x - 1, y] == 0) {
			return true;
		}
		return false;
	}
}