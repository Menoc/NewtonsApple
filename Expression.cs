using UnityEngine;
using ExpressionGenerator;

namespace NExpression
{
		public class Expression:Object
		{
				private int a, b, c;
				public enum Type
				{
						Single=0,
						Add,
						Sub,
						AddMull,
						AddAdd,
						AddSub,
						Mull,
						MullAdd
		}
				;
				/*
		 *  Single : 5 
		 *  Add    : 5+4
		 *  Sub    : 5-4
		 *  AddMull:5+4*3
		 *  AddAdd :5+4+2
		 *  AddSub 5+4-2
		 *  Mull  5*3
		 *  MullAdd 5+3*2
		 * */
				public void changeA (int _a)
				{
						this.a = _a;
				}

				public int A ()
				{
						return a;
				}

				public void changeB (int _b)
				{
						this.b = _b;
				}

				public void changeC (int _c)
				{
						this.c = _c;
				}

				public int B ()
				{
						return b;
				}

				public int C ()
				{
						return c;
				}

				public Type type;

				public static Expression makeRandomExpression ()
				{
						//var r = new Random ();
						int type = Random.Range (1, 7);
						return new Expression (type);
				}

				public Expression (int _type)
				{
						this.a = Random.Range (1, 4);
						this.b = Random.Range (1, 4);
						this.c = Random.Range (1, 4);
						switch (_type) {
						case 0:
								this.type = Type.Single;
								break;
						case 1:
								this.type = Type.Add;
								break;
						case 2:
								this.type = Type.Sub;
								break;
				
						case 3:
								this.type = Type.AddMull;
								break;
						case 4:
								this.type = Type.AddAdd;
								break;
						case 5:
								this.type = Type.AddSub;
								break;
						case 6:
								this.type = Type.Mull;
								break;
						case 7:
								this.type = Type.MullAdd;
								break;
						}
				}

				public Expression (Type _type)
				{
						this.type = _type;
						this.a = Random.Range (1, 4);
						this.b = Random.Range (1, 4);
						this.c = Random.Range (1, 4);
				}

				public override string ToString ()
				{
						switch (this.type) {
						case Type.Single:
								return a.ToString ();
						case Type.Add:
								return a.ToString () + " + " + b.ToString ();
						case Type.Sub:
								return a.ToString () + " - " + b.ToString ();
						case Type.AddMull:
								return a.ToString () + " +  " + b.ToString () + " x " + c.ToString ();
						case Type.AddAdd:
								return a.ToString () + " +  " + b.ToString () + " + " + c.ToString ();
						case Type.AddSub:
								return a.ToString () + " +  " + b.ToString () + " - " + c.ToString ();
						case Type.Mull:
								return a.ToString () + " x " + b.ToString ();
						case Type.MullAdd:
								return a.ToString () + " x " + b.ToString () + " + " + c.ToString ();
						default:
								return "failed Expression";
						}
				}
		
				public int eval ()
				{
						switch (this.type) {
						case Type.Single:
								return a;
						case Type.Add:
								return a + b;
						case Type.Mull:
								return a * b;
						case Type.AddAdd:
								return a + b + c;
						case Type.MullAdd:
								return a * b + c;
						case Type.AddSub:
								return a + b - c;

						case Type.AddMull:
								return a + b * c;
						case Type.Sub:
								return a - b;
						default:
								return -1;
						}
				}

				public static Expression generateExpressionThatEqualsOfType (int number, Type type)
				{
						var e = new Expression ();
	
						e.type = type;
						switch (type) {
						case Type.Single:
								e.changeA (number);
								break;
						case Type.Add:
								var p = ExpressionGenerator.ExpressionGenerator.makeAddExpressionThatEquals (number);
								e.changeA (p.Item1);
								e.changeB (p.Item2);
								break;
						case Type.AddAdd:
								var p1 = ExpressionGenerator.ExpressionGenerator.MakeAddAddExpressionThatEquals (number);
								e.changeA (p1.Item1);
								e.changeB (p1.Item2);
								e.changeC (p1.Item3);
								break;
						case Type.AddMull:
								p1 = ExpressionGenerator.ExpressionGenerator.makeAddMulExpressionThatEquals (number);
								e.changeA (p1.Item1);
								e.changeB (p1.Item2);
								e.changeC (p1.Item3);
								Debug.Log (" AddMull equals : " + e.eval().ToString());
								break;
						default:
								return makeRandomExpression ();
						}
						return e;
				}

				public static Expression generateExpressionThatEquals (int number)
				{
						int i = Random.Range (0, 6);
						if (i == 0) {
								return generateExpressionThatEqualsOfType (number, Type.Single);
						}
						if (i == 1) {
								return generateExpressionThatEqualsOfType (number, Type.AddAdd);
						}
						if (i == 2 || i == 3) {
								return generateExpressionThatEqualsOfType (number, Type.Add);
						}
						if (i == 4 || i == 5) {
								return generateExpressionThatEqualsOfType (number, Type.AddMull);
						}
						return makeRandomExpression ();
				}
		
				public Expression ()
				{
				}
		}
}
