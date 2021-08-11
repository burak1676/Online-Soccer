using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour
{
    //TextMesh scoretext;
   [SerializeField] TMPro.TextMeshProUGUI scoretext;
 
    
    
    
    // Start is called before the first frame update

    private void Awake()
    {
        scoretext = GetComponent<TMPro.TextMeshProUGUI>();
        GoalHolderBlue.mavitakimgol = 0;
        GoalHolderKirmizi.kýrmýzýtakýmgol = 0;

    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = " " + GoalHolderKirmizi.kýrmýzýtakýmgol;
    }
}
