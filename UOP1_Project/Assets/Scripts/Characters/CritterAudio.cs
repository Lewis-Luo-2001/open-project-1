using UnityEngine;

public class CritterAudio : CharacterAudio
{
	[SerializeField] private AudioCueSO _idleSound;
	[SerializeField] private AudioCueSO _moveSound;
	[SerializeField] private AudioCueSO _attackSound;
	[SerializeField] private AudioCueSO _gettingHitSound;
	[SerializeField] private AudioCueSO _deathSound;

	public void PlayIdleSound() => PlayAudio(_idleSound, _audioConfig, transform.position);
	//The move sound will not be called for the plant critter
	public void PlayMoveSound() => PlayAudio(_moveSound, _audioConfig, transform.position);
	public void PlayAttackSound() => PlayAudio(_attackSound, _audioConfig, transform.position);
	public void PlayGettingHitSound() => PlayAudio(_gettingHitSound, _audioConfig, transform.position);
	public void PlayDeathSound() => PlayAudio(_deathSound, _audioConfig, transform.position);

}
