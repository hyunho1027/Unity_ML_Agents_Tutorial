# 8. External Type으로 변경하여 강화학습을 통해 학습시킵니다.
- - -

## 8-1. GuideBrain 의 Brain Type를 External로 변경합니다.

Hierarchy의 GuideBrain 클릭 -> Inspector창 Brain Type을 External 로 변경

![Alt text](/unity_ml_agents_guide/8.change_external_mode/1.change_external.png)
- - -

## 8-2. 현재 Scene을 저장합니다.

File 클릭 -> Save Scenes 클릭

![Alt text](/unity_ml_agents_guide/8.change_external_mode/2.save_scene.png)
- - -

## 8-3. 현재 저장된 Scene을 Build 합니다.

File 클릭 -> Build Settings... 클릭

![Alt text](/unity_ml_agents_guide/8.change_external_mode/3.build.png)
- - -

## 8-4. 현재 저장된 Scene을 체크하고 Build합니다.

체크할 Scene가 없다면 Project창의 Scenes의 왼쪽 삼각형을 클릭하면 나오는 SampleScene를 드래그하여 Scenes In Build 창으로 옮깁니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/4.check_build_option.png)
- - -

## 8-5. Build할 폴더를 지정합니다.

아래 화면은 Build를 누르면 나오는 기본 경로입니다. 저는 기본적으로 설정된 위치에 Build 하였습니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/5.select_build_location.png)
- - -

## 8-6. Build가 완료되었는지 확인합니다.

Build가 완료되면 아래와 같이 Build된 경로의 폴더가 열립니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/6.complete_build.png)
- - -

## 8-7. mlagents를 install 해줍니다.

pip install mlagents

![Alt text](/unity_ml_agents_guide/8.change_external_mode/7.install_mlagents.png)
- - -

## 8-8. learn.py가 존재하는 folder를 path 설정해줍니다.

ml-agents\ml-agents\mlagents\trainers

![Alt text](/unity_ml_agents_guide/8.change_external_mode/8.path.png)

![Alt text](/unity_ml_agents_guide/8.change_external_mode/8-1.path.png)
- - -


## 8-9. 직접 학습을 시키기 위해 첫 부분에 다운받았던 ml-agents 폴더로 이동합니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/9.move_ml.png)
- - -

## 8-10. 학습을 시작합니다.

ml-agents 에서 실행합니다.

mlagents-learn <trainer-config-file> --env=<env_name> --run-id=<run-identifier> --train

을 통해 학습합니다.

ex. mlagents-learn config/trainer_config.yaml --env=[Build Path]/Guide_Project --run-id=Guide_1st --train

![Alt text](/unity_ml_agents_guide/8.change_external_mode/10.learn.png)
- - -

## 8-11. 학습이 잘 되고 있는지 Tensorboard를 이용하여 확인합니다.

ml-agents 에서 실행합니다.

tensorboard --logdir=summaries

를 이용하여 실행합니다.

아래와 같은 Url을 통해 Tensorboard에 접속합니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/11.open_tensorboard.png)
- - -

## 8-12. Tensorboard를 모니터링 합니다.

Runs에서 자신이 실행한 Project Name을 클릭하여 확인합니다.

![Alt text](/unity_ml_agents_guide/8.change_external_mode/12.tensorboard.png)
- - -

## [PREV_7. Player Type으로 테스트합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Guide/tree/master/unity_ml_agents_guide/7.test_player_mode)

## [NEXT_9. 학습한 Model을 사용하기 위해 TFSharp를 설치합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Guide/tree/master/unity_ml_agents_guide/9.download_TFSharp)

