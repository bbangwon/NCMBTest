using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class UserAuth : MonoBehaviour {

    public string userName;
    public string password;
    public string email;
	// Use this for initialization
	void Start () {
        SignUp(userName, password, email);		
	}
    
    public void SignUp(string userName, string password, string email)
    {
        //NCMBUser의 인스턴스 작성
        NCMBUser user = new NCMBUser();

        //사용자명과 비밀번호 설정
        user.UserName = userName;
        user.Password = password;
        user.Email = email;

        //회원등록을 한다.
        user.SignUpAsync((NCMBException e) =>
        {
            if(e != null)
            {
                Debug.Log("신규 등록 실패: " + e.ErrorMessage);
            }
            else
            {
                Debug.Log("신규 등록 성공");
            }
        });
    }
}
