using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleSheetsToUnity;

public class GameManager : MonoBehaviour
{

	public string associatedSheet = "13ocI06h4tvvB7ZEtKXruvQdWIH40ZMfgIYHSfiw34r0";
	public string associatedWorksheet = "March";

	private void Start() {
		SpreadsheetManager.Read(new GSTU_Search(associatedSheet, associatedWorksheet), UpdateAllAnimals);
		SpreadsheetManager.ReadPublicSpreadsheet(new GSTU_Search(associatedSheet, associatedWorksheet),
		UpdateAllAnimals);
	}

	void UpdateAllAnimals(GstuSpreadSheet spreadsheetRef) {
		print(spreadsheetRef["A2"].value);
	}
}
