# 8. External Type으로 변경하여 강화학습을 통해 학습시킵니다.
- - -

## 8-1. Learning Brain을 만들어 줍니다.

이름은 GuideLearningBrain으로 설정해줍니다.

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/1.make_learningbrain.png)
- - -

## 8-2. Platform에 GuideLearningBrain을 import 하고 Brain을 추가하여 Control을 체크해줍니다..

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/2.import_learningbrain.png)
- - -

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/2-1.import_learningbrain.png)
- - -

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/2-2.import_learningbrain.png)
- - -

## 8-3. GuideLearningBrain의 설정을 아래와 같이 변경합니다.

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/3.set_learningbrain.png)
- - -

## 8-4. 현재 Sence을 저장하고 빌드해줍니다.

저장 : File -> Save  
빌드 : File -> Build Settings

체크할 Scene이 없다면 Project창의 Scenes의 왼쪽 삼각형을 클릭하면 나오는 SampleScene를 드래그하여 Scenes In Build 창으로 옮깁니다.

Build

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/4.check_build_option.png)
- - -

## 8-5. Build할 폴더를 지정합니다.

본 가이드는 ml-agents의 폴더안에 Guide_Project폴더를 만들고 그 폴더에 빌드하였습니다. 

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/5.select_build_location.png)
- - -

## 8-6. Build가 완료되었는지 확인합니다.

Build가 완료되면 아래와 같이 Build된 경로의 폴더가 열립니다.

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/6.complete_build.png)
- - -

## 8-7. ml-agents에 필요한 환경을 설치합니다.

설치했던 ml-agents 폴더안의 ml-agents 폴더로 이동한 후  

아래와 같이 pip install . 명령어를 실행해 줍니다.

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/7.install_mlagents.png)
- - -

## 8-8. learn.py가 존재하는 folder를 path 설정해줍니다.

ml-agents\ml-agents\mlagents\trainers

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/8.path.png)

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/8-1.path.png)
- - -


## 8-9. 직접 학습을 시키기 위해 첫 부분에 다운받았던 ml-agents 폴더로 이동합니다.

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/9.move_ml.png)
- - -

## 8-10. 학습을 시작합니다.

ml-agents 에서 실행합니다.

mlagents-learn <trainer-config-file> --env=<env_name> --run-id=<run-identifier> --train

을 통해 학습합니다.

ex. mlagents-learn config/trainer_config.yaml --env=[Build Path]/Guide_Project --run-id=Guide_1st --train

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/10.learn.png)
- - -

## 8-11. 학습이 잘 되고 있는지 Tensorboard를 이용하여 확인합니다.

ml-agents 에서 실행합니다.

tensorboard --logdir=summaries

를 이용하여 실행합니다.

아래와 같은 Url을 통해 Tensorboard에 접속합니다.

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/11.open_tensorboard.png)
- - -

## 8-12. Tensorboard를 모니터링 합니다.

Runs에서 자신이 실행한 Project Name을 클릭하여 확인합니다.

![Alt text](/unity_ml_agents_tutorial/8.change_external_mode/12.tensorboard.png)
- - -

## [PREV_7. Player Type으로 테스트합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Tutorial/tree/master/unity_ml_agents_tutorial/7.test_player_mode)

## [NEXT_9. 학습이 완료된 Model을 Internal Type으로 실행합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Tutorial/tree/master/unity_ml_agents_tutorial/9.change_internal_mode)

