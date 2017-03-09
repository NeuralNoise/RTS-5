using UnityEngine;
using System.Collections;

public interface IBuilding
{
    IEnumerator BuildUnit(GameObject unit, float buildTime);    
}
