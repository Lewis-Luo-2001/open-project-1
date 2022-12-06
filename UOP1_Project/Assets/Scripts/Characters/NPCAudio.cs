using UnityEngine;

public class NPCAudio : CharacterAudio
{
	[SerializeField] private AudioCueSO _singShort;
	[SerializeField] private AudioCueSO _singLong; 
	[SerializeField] private AudioCueSO _talk; 
	[SerializeField] private AudioCueSO _footstep;

	//Only bard hare will use the Idle since he sings at that time
	public void PlaySingLong() => PlayAudio(_singLong, _audioConfig, transform.position);
	public void PlaySingShort() => PlayAudio(_singShort, _audioConfig, transform.position);
	//when we have the ground detector script, we should check the type to know which footstep sound to play
	public void PlayTalk() => PlayAudio(_talk, _audioConfig, transform.position);
	public void PlayFootstep() => PlayAudio(_footstep, _audioConfig, transform.position);

}
