using UnityEngine;

public class animate : MonoBehaviour
{
    private Animator playerAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        playerAnimator.SetFloat("walk", Input.GetAxis("Vertical"));
        playerAnimator.SetBool("jump 0", Input.GetButton("Jump"));

        //pour activer une animation a lappuie dun boutton
        //playerAnimator.SetBool("nom de la varriable valeur(0)",Input.GetButton("nom du boutton dans les input(dans edit/projectSetting)))
    }
}
