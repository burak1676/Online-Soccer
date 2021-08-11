using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabelaScoreHolder : MonoBehaviour
{
    TextMesh scoretext;
   




    // Start is called before the first frame update

    private void Awake()
    {
        scoretext = GetComponent<TextMesh>();
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
