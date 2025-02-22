
using UnityEngine;
using UnityEngine.UI;

public  class HPBar : MonoBehaviour //By Jacob Foran (https://www.youtube.com/watch?v=_lREXfAMUcE&list=LL&index=1&t=58s)
{
     Slider enemyHBar;
    private void Start()
    {
        enemyHBar = GetComponent<Slider>();
    }
    public void UpdateHBar(float currentEnemyHealth, float maxEnemyHealth)
    {
        if(enemyHBar !=null)
        {
             enemyHBar.value = currentEnemyHealth / maxEnemyHealth;
        }
        else
        {
            Debug.Log("HPBar slider not found");
        }
    }
}
