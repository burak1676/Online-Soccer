using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabelaBlueScoreHolder:MonoBehaviour
{
    // Start is called before the first frame update
    TextMesh scoretext2;
    

    // Start is called before the first frame update

    private void Awake()
    {
        scoretext2 = GetComponent<TextMesh>();
        GoalHolderBlue.mavitakimgol = 0;
        GoalHolderKirmizi.kýrmýzýtakýmgol = 0;

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoretext2.text = " " + GoalHolderBlue.mavitakimgol;
    }
}
