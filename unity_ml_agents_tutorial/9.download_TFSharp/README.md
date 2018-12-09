# 9. TFSharp 설치 및 Player 설정을 바꿔줍니다.

## 9-1.학습한 Model을 사용하기 위해 TFSharp를 설치합니다.
- - -

TFSharp 설치 Url : http://s3.amazonaws.com/unity-ml-agents/0.3/TFSharpPlugin.unitypackage

설치를 완료하고 실행합니다.

![Alt text](/unity_ml_agents_tutorial/9.download_TFSharp/1.TFSharp_down.png)
- - -

## 4-6. 다음 Other Settings의 탭으로 이동하여 설정을 아래와 같이 변경합니다.

Scripting Runtime Version을 .NET 4.x 버전으로 바꿔줍니다.

![Alt text](/unity_ml_agents_tutorial/4.import_ml_agents/6.set_4.x.png)
- - -

## 4-7. 재시작을 하라는 창이 뜨면 Restart를 눌러 재시작 해줍니다.

![Alt text](/unity_ml_agents_tutorial/4.import_ml_agents/7.restart.png)
- - -

## 4-8. Other Setting 탭의 설정이 변경된 걸 확인하고 Scripting Define Symbols* 설정을 아래와 같이 변경합니다.

Scripting Runtime Version -> .NET 4.x Equivalent 로 변경
Api Compatibility Level* -> .NET 4.x 로 변경

Scripting Define Symbols* -> ENABLE_TENSORFLOW 입력

![Alt text](/unity_ml_agents_tutorial/4.import_ml_agents/8.ENABLE_TENSORFLOW.png)
- - -

## [PREV_8. External Type으로 변경하여 강화학습을 통해 학습시킵니다.](https://github.com/hyunho1027/Unity_ML_Agents_Tutorial/tree/master/unity_ml_agents_tutorial/8.change_external_mode)

## [NEXT_10. 학습이 완료된 Model을 Internal Type으로 실행합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Tutorial/tree/master/unity_ml_agents_tutorial/10.change_internal_mode)
