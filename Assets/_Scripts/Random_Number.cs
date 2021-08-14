using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Random_Number : MonoBehaviour
{

    [Header("Assign Animators")]

    [SerializeField] Animator anim_1;
    [SerializeField] Animator anim_2;
    [SerializeField] Animator anim_3;


    [Header("Assign Number Text")]

    [SerializeField] Button button;
  


    [Header("Assign Number Text")]

    [SerializeField] TextMesh number_1;
    [SerializeField] TextMesh number_2;
    [SerializeField] TextMesh number_3;

    [Header("Assign Max and Minimum")]

    [SerializeField] float Max = 3;
    [SerializeField] float Min = 1;

    [Header("Wait Time")]

    [SerializeField] float time = 1.5f;


    private float number_1_int;
    private float number_2_int;
    private float number_3_int;

    public void StartRandomNumber()
    {
        StartCoroutine(Randomnumber());
    }
    public void WinOrLose()
    {
        if(number_1_int == number_2_int && number_1_int == number_3_int)
        {
            Debug.Log("You Win!");

            number_1.text = "0";
            number_2.text = "0";
            number_3.text = "0";

            button.interactable = true;
        }
        else
        {
            Debug.Log("Try Again!");

            button.interactable = true;

            number_1.text = "0";
            number_2.text = "0";
            number_3.text = "0";
        }
    }

    private IEnumerator Randomnumber()
    {


        button.interactable = false;

        // animtiaon

        anim_1.SetTrigger("Sing");

        number_1_int = Random.Range(Min, Max);

        number_1.text = number_1_int.ToString("0");

        yield return new WaitForSecondsRealtime(time);

        // animtiaon

        anim_2.SetTrigger("Sing");

        number_2_int = Random.Range(Min, Max);

        number_2.text = number_2_int.ToString("0");

        yield return new WaitForSecondsRealtime(time);

        // animtiaon

        anim_3.SetTrigger("Sing");


        number_3_int = Random.Range(Min, Max);


        number_3.text = number_3_int.ToString("0");

       
        
        
        
        yield return new WaitForSecondsRealtime(time);

        
        
        WinOrLose();

        

    }








}
