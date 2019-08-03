using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

/*
 * <Arrow Rhythm Game Project>
 * MainMenu.cs
 * => Main Scene & Option Scene Script
 * Author : Adrain(정희석)
 * <Naming Rule> by Adrain
 * Object Name > 아래 첨자 (ex) main_holder
 * Function Name > CamelCase(대문자 로시작) (ex) MapSelection
 * Scene Name > CamelCase & 아래첨자 (ex) Main_Menu
 */
public class MainMenu : MonoBehaviour
{
    public GameObject main_holder;      //MainPanel
    public GameObject option_holder;    //OptionPanel
    public GameObject toast_holder;
    bool o_chk = false;
    bool k_chk = false;
    bool isTrue = false;
    // Start is called before the first frame update
    void Start()
    {
        main_holder.SetActive(true);
        option_holder.SetActive(false);
        toast_holder.SetActive(false);
        Debug.Log("Application Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (o_chk)
            {
                main_holder.SetActive(false);
                toast_holder.SetActive(true);
                PressBackKey();
            }
            else
            {
                o_chk = false;
                main_holder.SetActive(true);
                option_holder.SetActive(false);
                toast_holder.SetActive(false);
            }
        } 
    }
    // PressBackKey is called when user press Back Key(or Escape Key)
    void PressBackKey()
    {
        Debug.Log("User Try 2 Exit");
        //while (!k_chk) ; //wait for input
        k_chk = false;
        if (isTrue)
        {
            Application.Quit();
        }
        else
        {
            main_holder.SetActive(true);
            toast_holder.SetActive(false);
        }
    }
    // Option is called when user press 게임설정 button
    public void Option() //다른 스크립트에서는 SceneManager.LoadScene("MainMenu"); & Option()호출
    {
        o_chk = true;
        Debug.Log("Move 2 Option");
        main_holder.SetActive(false);
        option_holder.SetActive(true);
    }
    // MapSelection is called when user press 게임시작 button
    public void MapSelection()
    {
        Debug.Log("Move 2 MapSelection");
        SceneManager.LoadScene("MainMenu");
    }
    // Tutorial is called when user press 튜ㅡ토ㅡ리ㅡ얼 button
    public void Tutorial()
    {
        Debug.Log("Move 2 Tutorial");
        SceneManager.LoadScene("Tutorial");
    }
    // setTrue is called when user press 예 button on Toast Message Scene
    public void setTrue()
    {
        Debug.Log("Allow Quit");
        k_chk = true;
        isTrue = true;
    }
    // setFalse is called when user press 아니요 button on Toast Message Scene
    public void setFalse()
    {
        Debug.Log("Deny Quit");
        k_chk = true;
        isTrue = false;
    }
    
}
