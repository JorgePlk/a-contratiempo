using UnityEngine;
using System.Collections;

namespace Rhythmify
{

	public class ChangeColors : _AbstractRhythmObject
	{
		private int indice=0;//por donde vamos
		public int[] bpm;//el pulso donde se realiza algo
		public int[] elto;
		public int[] donde;
		public GameObject[] zonas;
		public GameObject[] elementos;


		override protected void beatUpdate (int beat)
		{
			if (beat == bpm [indice]) {
				Vector3 v = zonas [donde [indice]].transform.position + new Vector3 (0, 0, 0);
				Instantiate(elementos[elto[indice]],v,zonas[donde[indice]].transform.rotation);
				indice ++;
			}
		}
	}
}