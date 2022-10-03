using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour
{
    public TextMeshProUGUI p1Name;
    public TextMeshProUGUI p2Name;
    public TextMeshProUGUI p1HPUI;
    public TextMeshProUGUI p2HPUI;
    public GameObject specialButton1;
    public GameObject specialButton2;
    public int p1HP = 100;
    public int p2HP = 100;
    public VideoClip VD1, VD2, VD3, VD4, VD5, VD6, VD7, VD8, VD9, VD10;


    public void Awake(){
        p1Name.text = Scene1.scene1.player1Name;
        p2Name.text = Scene1.scene1.player2Name;
    }

    void Update()
    {
        p1HPUI.GetComponent<TMPro.TextMeshProUGUI>().text = "HP: " + p1HP;
        p2HPUI.GetComponent<TMPro.TextMeshProUGUI>().text = "HP: " + p2HP;
    }

   
    public void dealDamage(int damage, int playerHP){
           
            playerHP -= damage;
            player1HP = playerHP;
    }
    public void attackDamage(int damage, int playerHP){
           
            playerHP -= damage;
            player2HP = playerHP;
            
    }

    void attack(float accuracy, IEnumerator attackname, VideoClip video){
        int x = Random.Range(1, 101);

        if(x <= accuracy){
            VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = video;
            VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
            StartCoroutine(attackname);
            Debug.Log("Attack Success!");
        }
        else{
            Debug.Log("Attack Missed!");
        }
    }
    //ATTACK SUCCESS
    public void p1Lowpunch(){
        attack(95, p1Lowpunchdelay(), VD6);
    }
    public void p1Highpunch(){
        attack(75, p1Highpunchdelay(), VD7);
    }
    public void p1Lowkick(){
        attack(90, p1Lowkickdelay(), VD8);
    }
    public void p1Highkick(){
        attack(65, p1Highkickdelay(), VD9);
    }
    public void p1Special(){
        attack(95, p1Specialdelay(), VD10);
        p1specialattk.SetActive(false);
    }
    IEnumerator p1Lowpunchdelay(){
        yield return new WaitForSeconds(2F);
        attackDamage(5, player2HP);
    }
    IEnumerator p1Highpunchdelay(){
        yield return new WaitForSeconds(3F);
        attackDamage(10, player2HP);
    }
    IEnumerator p1Lowkickdelay(){
        yield return new WaitForSeconds(2F);
        attackDamage(3, player2HP);
    }
    IEnumerator p1Highkickdelay(){
        yield return new WaitForSeconds(3F);
        attackDamage(7, player2HP);
    }
    IEnumerator p1Specialdelay(){
        yield return new WaitForSeconds(5F);
        attackDamage(15, player2HP);
    }
    public void p2Lowpunch(){
        attack(95, p2Lowpunchdelay(), VD1);
    }
    public void p2Highpunch(){
        attack(75, p2Highpunchdelay(), VD2);
    }
    public void p2Lowkick(){
        attack(90, p2Lowkickdelay(), VD3);
    }
    public void p2Highkick(){
        attack(65, p2Highkickdelay(), VD4);
    }
    public void p2Special(){
        attack(95, p2Specialdelay(), VD5);
        p2specialattk.SetActive(false);
    }

    IEnumerator p2Lowpunchdelay(){
        yield return new WaitForSeconds(3F);
        dealDamage(5, player1HP);
    }
    IEnumerator p2Highpunchdelay(){
        yield return new WaitForSeconds(2F);
        dealDamage(10, player1HP);
    }
    IEnumerator p2Lowkickdelay(){
        yield return new WaitForSeconds(2F);
        dealDamage(3, player1HP);
    }
    IEnumerator p2Highkickdelay(){
        yield return new WaitForSeconds(3F);
        dealDamage(7, player1HP);
    }
    IEnumerator p2Specialdelay(){
        yield return new WaitForSeconds(5F);
        dealDamage(15, player1HP);
    }

}
