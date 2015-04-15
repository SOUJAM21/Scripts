using UnityEngine;
using System.Collections;

public class Waves : MonoBehaviour {


	
	[ExecuteInEditMode]
	
	
	public class UVScroller : MonoBehaviour
	{
		
		float m_fFlowMapOffset0 = 0.0f;
		float m_fFlowMapOffset1 = 0.0f;
		float m_fFlowSpeed = 0.05f;
		float m_fCycle = 0.15f;
		float m_fWaveMapScale = 2.0f;
		
		public void Update ()
		{
			//update the flow map offsets for both layers
			m_fFlowMapOffset0 += m_fFlowSpeed * Time.deltaTime;
			m_fFlowMapOffset1 += m_fFlowSpeed * Time.deltaTime;
			
			if ( m_fFlowMapOffset0 >= m_fCycle )
				m_fFlowMapOffset0 = 0.0f;
			
			if ( m_fFlowMapOffset1 >= m_fCycle )
				m_fFlowMapOffset1 = 0.0f;
			
			float _fHalfCycle = m_fCycle*0.5f;
			
			Shader.SetGlobalFloat("fFlowMapOffset0", m_fFlowMapOffset0);
			Shader.SetGlobalFloat("fFlowMapOffset1", m_fFlowMapOffset1);
			Shader.SetGlobalFloat("halfCycle", _fHalfCycle);
			Shader.SetGlobalFloat("fWaveSpeed", m_fFlowSpeed);
			Shader.SetGlobalFloat("fWaveScale", m_fWaveMapScale);
		}
	}

}
