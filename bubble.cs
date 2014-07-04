using UnityEngine;
using System.Collections;
using NExpression;

public class bubble : MonoBehaviour
{
		
		public bool correctBuble;
		public static bool existsCorrectBuble=false;
		public TextMesh text;
		public mainscript main;
		Expression e;

		void Start ()
		{
				main = GameObject.FindGameObjectWithTag ("main").GetComponent<mainscript> ();
				e = Expression.makeRandomExpression ();
				int i = Random.Range (0, 63);
				if (i%2==0 && existsCorrectBuble==false) {
						e = Expression.generateExpressionThatEquals(main.target);
						correctBuble=true;
						existsCorrectBuble=true;
			}
				text.text = e.ToString ();
				//main.targetText.text = "Target Value: " + main.target;
		}

		void OnMouseDown ()
		{
				if (e.eval ()==main.target) {
						Debug.Log ("true");
						main.score++;
						Destroy (transform.parent.gameObject);
						main.scoreText.text = "Score: " + main.score;
						main.target = 13;//Random.Range (1, 16);
						main.targetText.text = "Target Value: " + main.target;
						existsCorrectBuble=false;
				} else {
						Debug.Log ("false");
						main.score--;
						Destroy (transform.parent.gameObject);
						main.scoreText.text = "Score: " + main.score;
				
				}	
				Debug.Log (main.target.ToString ());
		}
}
