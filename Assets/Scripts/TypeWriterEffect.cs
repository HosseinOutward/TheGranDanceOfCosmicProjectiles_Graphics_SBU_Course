using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour {

	public float delay = 0.1f;
	public string fullText;
    public Text textBox;
    public GameObject text_canvas;
    public int from_here = 0;
    public int i = 0;
	private string currentText = "";

    public bool Text_done = false;

	// Use this for initialization
	void Start () {
		StartCoroutine(ShowText());
	}
	
    private void Update()
    {
        if(Input.GetButton("Fire1")){
            delay = 0.01f;
            if(i>=fullText.Length){
                Text_done = true;
                text_canvas.SetActive(false);
            }
        }else
        {
            delay = 0.1f;
        }
    }
	IEnumerator ShowText(){



		if(i >= fullText.Length) {
                

                if(Input.GetButton("Fire1")) {
                Destroy(text_canvas);
                }

                Text_done = true;

                yield return new WaitForSeconds(20 * delay);
                Destroy(text_canvas);

            }

		while(i < fullText.Length) {	

            if(fullText[i] == ';') {
                from_here = i + 1;
                while(true){
                    if(Input.GetButton("Fire1")){
                        break;
                    }
                    yield return new WaitForSeconds(delay);
                }
                this.GetComponent<TMPro.TextMeshProUGUI>().text = "";
            }


            currentText = fullText.Substring(from_here, i - from_here + 1);
			this.GetComponent<TMPro.TextMeshProUGUI>().text = currentText;
            yield return new WaitForSeconds(delay);

            i += 1;

            
            
		}

        
        
	}
}