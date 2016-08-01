using UnityEngine;
using System.Collections;

namespace Rhythmify
{

	public class ChangeColors : _AbstractRhythmObject
	{
		public GameObject prefab;
//objeto a instanciar
		public Vector3[] posiciones;
//posiciones en las que instanciar
		public int[] indices1;
//indices para decidir
		public int offset;
//beat de comienzo

		override protected void beatUpdate (int beat)
		{
			int size = posiciones.Length;

			if (size < 0) {
				return;
			}
			if (beat >= offset) {// en total hasta aquí es si hay posiciones en el array y ha comenzado la canción
				int idx = beat - offset;
				if (indices1.Length > 0) {
					idx = indices1 [idx % indices1.Length];//cogemos el indice que toque
				}

				if (idx < 0) {
					return;
				}
				//si el indice no es menor que cero 
				Vector3 t = posiciones [idx % size];
				Instantiate (prefab, t, transform.rotation);//instanciamos un objeto en la posición indicada
			}
		}
	}
}
