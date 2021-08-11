using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolderBlue : MonoBehaviour
{
    // Start is called before the first frame update
    //TextMesh scoretext2;
   [SerializeField] TMPro.TextMeshProUGUI scoretext2;

    // Start is called before the first frame update

    private void Awake()
    {
        scoretext2 = GetComponent<TMPro.TextMeshProUGUI>();
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
