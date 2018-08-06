# 5. 학습할 환경을 구축합니다.

## 5-1. Hierarchy 창에 Cube를 생성합니다.

Hierarchy 창 우클릭 -> 3D Object -> Cube

![Alt text](/unity_ml_agents_guide/5.make_env/1.make_cube.png)

## 5-2. Cube의 설정을 변경합니다.

Hierarchy 의 Cube 클릭 -> Inspector창에서 이름 Platform 입력 -> Transform 정보 입력

![Alt text](/unity_ml_agents_guide/5.make_env/2.make_platform.png)

## 5-3. Platform 에 Rigidbody 설정을 추가합니다.

Hierarchy의 platform 클릭 -> Inspector창의 AddComponent 클릭 -> Rigidbody 입력 -> Rigidbody 클릭

![Alt text](/unity_ml_agents_guide/5.make_env/3.add_rigid_body.png)

## 5-4. Platform 의 Rigidbody 설정을 아래와 같이 변경합니다.

Hierarchy의 Platform 클릭 -> Inspector창의 Rigidbody 설정에서 Is Kinematic 체크

![Alt text](/unity_ml_agents_guide/5.make_env/4.Check_Is_Kinematic.png)

## 5-5. Hierarchy 창에 Sphere를 생성합니다.

Hierarchy 창 우클릭 -> 3D Object -> Sphere

![Alt text](/unity_ml_agents_guide/5.make_env/5.make_sphere.png)

## 5-6 Sphere의 설정을 변경합니다.

Hierarchy 의 Sphere 클릭 -> Inspector창에서 이름 Ball 입력 -> Transform 정보 입력

![Alt text](/unity_ml_agents_guide/5.make_env/6.make_ball.png)

## 5-7. Ball 에 Rigidbody 설정을 추가합니다.

Hierarchy의 Ball 클릭 -> Inspector창의 AddComponent 클릭 -> Rigidbody 입력 -> Rigidbody 클릭

![Alt text](/unity_ml_agents_guide/5.make_env/7.add_rigidbody.png)

## 5-8. Ball과 Platform에 색을 입히기 위해 Material을 2개 생성합니다.

Project창 우클릭 -> Create -> Material -> 이름을 Ball, Platform으로 변경

![Alt text](/unity_ml_agents_guide/5.make_env/8.make_material.png)

## 5-9. Ball Material을 Ball에 import 합니다.

Project 창의 Ball Material을 드래그하여 Hierarchy 창의 Ball에 옮깁니다.

![Alt text](/unity_ml_agents_guide/5.make_env/9.import_ballmaterial.png)

## 5-10. Platform Material을 Platform에 import 합니다.

Project 창의 Platform Material을 드래그하여 Hierarchy 창의 Platform에 옮깁니다.

![Alt text](/unity_ml_agents_guide/5.make_env/10.import_platformmaterial.png)

## 5-11. Ball Material로 Ball을 원하는 색으로 변경합니다.

Project 창의 Ball Material 클릭 -> Inspector의 Albedo 옆 상자 클릭 -> 원하는 색으로 설정

![Alt text](/unity_ml_agents_guide/5.make_env/11.change_ball_color.png)

## 5-12. Platform Material로 Platform을 원하는 색으로 변경합니다.

Project 창의 Platform Material 클릭 -> Inspector의 Albedo 옆 상자 클릭 -> 원하는 색으로 설정

![Alt text](/unity_ml_agents_guide/5.make_env/12.change_platform_color.png)
- - -

## [NEXT_6. Academy와 Agent를 생성합니다.](https://github.com/hyunho1027/Unity_ML_Agents_Guide/tree/master/unity_ml_agents_guide/6.make_academy_and_agents)
