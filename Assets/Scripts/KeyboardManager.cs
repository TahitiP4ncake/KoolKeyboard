using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeyboardManager : MonoBehaviour {

	public List<GameObject> lettres;

	public GameObject leftTrans;
	public GameObject rightTrans;

	public AnimationCurve glow;

    string previousKey;



    /*
	bool aOn;
	bool bOn;
	bool cOn;
	bool dOn;
	bool eOn;
	bool fOn;
	bool gOn;
	bool hOn;
	bool iOn;
	bool jOn;
	bool kOn;
	bool lOn;
	bool mOn;
	bool nOn;
	bool oOn;
	bool pOn;
	bool qOn;
	bool rOn;
	bool sOn;
	bool tOn;
	bool uOn;
	bool vOn;
	bool wOn;
	bool xOn;
	bool yOn;
	bool zOn;

    */
    #region Letters

    public GameObject a;
	public GameObject b;
	public GameObject c;
	public GameObject d;
	public GameObject e;
	public GameObject f;
	public GameObject g;
	public GameObject h;
	public GameObject i;
	public GameObject j;
	public GameObject k;
	public GameObject l;
	public GameObject m;
	public GameObject n;
	public GameObject o;
	public GameObject p;
	public GameObject q;
	public GameObject r;
	public GameObject s;
	public GameObject t;
	public GameObject u;
	public GameObject v;
	public GameObject w;
	public GameObject x;
	public GameObject y;
	public GameObject z;

    [Space]

    public GameObject A0;
    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject A6;
    public GameObject A7;
    public GameObject A8;
    public GameObject A9;

    [Space]

    public GameObject interogation;
    public GameObject exclamation;
    public GameObject et;
    public GameObject arobas;

    #endregion

    float xPosition;

    float timer;
    public float maxTime;

	public GameObject[] titre;

	void Start()
	{
		StartCoroutine (Title ());
	}

	IEnumerator Title()
	{
		xPosition = .2f;
		foreach (GameObject _lettre in titre) {
			Type (_lettre);
			yield return new WaitForSeconds (.05f);
		}
	}
    
    void Update ()
    {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			//Application.Quit ();
			foreach (GameObject _lettre in lettres) {
				Destroy (_lettre);
			}
			xPosition = 0;
		}

        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            Erase();
            Invoke("StartErase", .3f);
        }

        if(Input.GetKeyUp(KeyCode.Backspace))
        {
            CancelInvoke();
        }

        timer += Time.deltaTime;

        if(timer>=maxTime)
        {
            timer = 0;
            xPosition = 0;
        }

        CheckInputs ();
	}

    void StartErase()
    {
        InvokeRepeating("Erase", 0f, 0.08f);
    }

	void Erase()
    {
        if (lettres.Count > 0)
        {
            GameObject _lettre = lettres[lettres.Count - 1];
            lettres.RemoveAt(lettres.Count - 1);
            Destroy(_lettre);
        }
    }

    void Type(GameObject _letter)
    {
        GameObject _lettre = Instantiate(_letter, Vector3.Lerp(leftTrans.transform.position,rightTrans.transform.position,xPosition), leftTrans.transform.rotation);
		lettres.Add (_lettre);
        xPosition += .05f;
        if (xPosition >  1)
            xPosition = 0;

        timer = 0;
    }

	void CheckInputs()
	{

        if (Input.GetKeyDown(KeyCode.Space))
        {
            xPosition += .05f;
            if (xPosition >= 1)
                xPosition = 0;

            timer = 0;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            xPosition = 0;
            timer = 0;
        }

        if (Input.GetKeyDown(KeyCode.A) && a != null)
            
            {
            Type(a);
                previousKey = "a";
                
            }

        if (Input.GetKeyDown(KeyCode.B) && b != null)

            {
            Type(b);
            previousKey = "b";
            }

        if (Input.GetKeyDown(KeyCode.C) && c != null)
            {
            Type(c);
            previousKey = "c";
            }

        if (Input.GetKeyDown(KeyCode.D) && d != null )

            {
            Type(d);
            previousKey = "d";
            }

        if (Input.GetKeyDown(KeyCode.E) && e != null)
            {
            Type(e);
            previousKey = "e";

            }

        if (Input.GetKeyDown(KeyCode.F) && f != null)
            {
            Type(f);
            previousKey = "f";
            }

        if (Input.GetKeyDown(KeyCode.G) && g != null)
            {
            Type(g);
            previousKey = "g";
            }

        if (Input.GetKeyDown(KeyCode.H) && h != null)
            {
            Type(h);
            previousKey = "h";
            }

        if (Input.GetKeyDown(KeyCode.I) && i != null)
            {
            Type(i);
            previousKey = "i";
            }

        if (Input.GetKeyDown(KeyCode.J) && j != null)
            {
            Type(j);
            previousKey = "j";
            }

        if (Input.GetKeyDown(KeyCode.K) && k != null)
            {
            Type(k);
            previousKey = "k";
            }

        if (Input.GetKeyDown(KeyCode.L) && l != null)
            {
            Type(l);
            previousKey = "l";
            }

        if (Input.GetKeyDown(KeyCode.M) && m != null)
            {
            Type(m);
            previousKey = "m";
            }

        if (Input.GetKeyDown(KeyCode.N) && n != null)
            {
            Type(n);
            previousKey = "n";
            }

        if (Input.GetKeyDown(KeyCode.O) && o != null)
            {
            Type(o);
            previousKey = "o";
            }

        if (Input.GetKeyDown(KeyCode.P) && p != null)
            {
            Type(p);
            previousKey = "p";
            }

        if (Input.GetKeyDown(KeyCode.Q) && q != null)
            {
            Type(q);
            previousKey = "q";
            }

        if (Input.GetKeyDown(KeyCode.R) && r != null)
            {
            Type(r);
            previousKey = "r";
            }

        if (Input.GetKeyDown(KeyCode.S) && s != null)
            {
            Type(s);
            previousKey = "s";
            }

        if (Input.GetKeyDown(KeyCode.T) && t != null)
            {
            Type(t);
            previousKey = "t";
            }

        if (Input.GetKeyDown(KeyCode.U) && u != null)
            {
            Type(u);
            previousKey = "u";
            }

        if (Input.GetKeyDown(KeyCode.V) && v != null)
            {
            Type(v);
            previousKey = "v";
            }

        if (Input.GetKeyDown(KeyCode.W) && w != null)
        {
            Type(w);
         previousKey = "w";
            }

        if (Input.GetKeyDown(KeyCode.X) && x != null)
            {
            Type(x);
            previousKey = "x";
            }

        if (Input.GetKeyDown(KeyCode.Y) && y != null)
            {
            Type(y);
            previousKey = "y";
            }

        if (Input.GetKeyDown(KeyCode.Z) && z != null)
            {
            Type(z);
            previousKey = "z";
            }

        if (Input.GetKeyDown(KeyCode.BackQuote) && exclamation != null)
        {
            Type(exclamation);
            previousKey = "!";
        }
        
        if (Input.GetKeyDown(KeyCode.Comma) && interogation != null)
        {
            Type(interogation);
            previousKey = "?";
        }

        if (Input.GetKeyDown(KeyCode.Alpha0) && arobas != null)
        {
            Type(arobas);
            previousKey = "@";
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && et != null)
        {
            Type(et);
            previousKey = "&";
        }

        if (Input.GetKeyDown(KeyCode.Keypad0) && A0!= null)
        {
            Type(A0);
            previousKey = "0";
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) && A1 != null)
        {
            Type(A1);
            previousKey = "1";
        }

        if (Input.GetKeyDown(KeyCode.Keypad2) && A2 != null)
        {
            Type(A2);
            previousKey = "2";
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) && A3 != null)
        {
            Type(A3);
            previousKey = "3";
        }

        if (Input.GetKeyDown(KeyCode.Keypad4) && A4 != null)
        {
            Type(A4);
            previousKey = "4";
        }

        if (Input.GetKeyDown(KeyCode.Keypad5) && A5 != null)
        {
            Type(A5);
            previousKey = "5";
        }

        if (Input.GetKeyDown(KeyCode.Keypad6) && A6 != null)
        {
            Type(A6);
            previousKey = "6";
        }

        if (Input.GetKeyDown(KeyCode.Keypad7) && A7 != null)
        {
            Type(A7);
            previousKey = "7";
        }

        if (Input.GetKeyDown(KeyCode.Keypad8) && A8 != null)
        {
            Type(A8);
            previousKey = "8";
        }

        if (Input.GetKeyDown(KeyCode.Keypad9) && A9 != null)
        {
            Type(A9);
            previousKey = "9";
        }


    }

    /*
    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
            Debug.Log("Detected key code: " + e.keyCode);

    }
    */

}
