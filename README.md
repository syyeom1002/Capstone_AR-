
# [잘조립 Portfolio]


## 1. 프로젝트 소개

<div align="center">

  <img src="https://github.com/user-attachments/assets/bbf87c18-8bb5-4f78-8f3b-89815df475c1" width="49%" height="280"/>
  <img src="https://github.com/user-attachments/assets/a0516eea-442e-41ec-bed1-6819eab7db4c" width="49%" height="280"/>
  <img src="https://github.com/user-attachments/assets/0a0f3334-245d-4794-94d4-1f2665892f00" width="49%" height="280"/>
  <img src="https://github.com/user-attachments/assets/cdb9eb56-9511-4ea5-b8d5-fc3420dbd165" width="49%" height="280"/>

  < 게임 플레이 사진 >

</div>

> + 졸업 작품으로 진행한 프로젝트 입니다. 잘조립은 종이 가구 조립 설명서의 불편함을 없애고자 만든 어플리케이션 입니다. 
> 어플에 접속하여 핸드폰 카메라로 가구의 바코드나 설명서에 있는 완성된 가구의 입체도 또는 사진 등을 인식하면, 해당 가구의 조립법을 증강현실(AR)을 이용하여 가구의 조립 순서대로 3D로 띄워줍니다. 
> 국적과 나이 관계없이 사용자들이 설명서를 직접적으로 이해하지 않아도 가구조립을 보다 쉽게 할 수 있습니다. 또한 핸드폰을 이용하여 설명서를 보기 때문에 종이 소비를 줄일 수 있습니다. 
> 
> + 개발기간: 2022.03.07 ~ 2022.06.03 ( 약 3개월 )


<br>

## 2. 개발 환경

+ 개발 엔진 : Unity 2022.3.5f1 

+ 언어 : C#

+ 플랫폼 : oculus

+ 형상 관리: SVN

<br>

## 3. 사용 기술
| 기술 | 설명 |
|:---:|:---|
| Oculus Interaction | Grab, OVRInput, Haptics, Hand Grab Pose, Ray |
| Queue | 미션 UI의 팔로우 로직 및 방패 찍기 구현 |
| Curved UI | scrollView와 더불어 캐릭터 선택 UI 구현 |
| 라이트맵| 성능의 최적화를 위해 라이트맵을 이용하여 게임 맵 구성 fps 40->60 |
| 내적(Dot) | 방패 던지기 방향 구현 |
| OverlapSphere | 반경 안에 있는 적 감지 |
| Dotween | 방패 회전 구현 |
| Event Wrapper | 스페이스 스톤 획득 시 씬 전환 이벤트 처리 |

<br>

## 4. 개발 인원 및 담당

+ 인원 : 총 4인 (Unity 2인, Android 2인)
+ 담당 : 팀장, 가구 부품 모델링, 가구의 이동(설명서의 짝수 번호)

<br>

## 5. 핵심 기능


#### 캐릭터 선택
<img src="https://github.com/user-attachments/assets/11cc95ff-1e0a-41db-99a3-302b18869e95" width="49%" height="280"/>

+ Controller의 Thumbstick 으로 좌우 이동
+ Controller의 A버튼 클릭하면 캐릭터 선택 완료, 게임씬으로 전환


#### 이동 시스템
<div align="center">

  <img src="https://github.com/user-attachments/assets/0c9152d7-3a7b-4341-8474-9505adc12a4f" width="49%" height="280"/>
  <img src="https://github.com/user-attachments/assets/2dad20b5-6b8c-481f-a554-48394df6d80d" width="49%" height="280"/>

</div>

+ 자동 이동
+ Leap : Contoller의 A 버튼을 이용하여 이동 가능


#### 공격
<div align="center">

  <img src="https://github.com/user-attachments/assets/e561759c-4568-4fc2-9fe4-ba2b972b0adb" width="49%" height="280"/>
  <img src="https://github.com/user-attachments/assets/a9fb460c-7c83-4f43-928b-f6cc181c6bed" width="49%" height="280"/>

</div>

+ 방패 던지기 : Controller의 HandTrigger버튼으로 조작 가능
+ 방패 찍기 : Controller의 IndexTrigger 버튼으로 조작 가능


#### 적
<div align="center">

  <img src="https://github.com/user-attachments/assets/681a87de-7626-4a73-904e-093a1984104b" width="49%" height="280"/>
  <img src="https://github.com/user-attachments/assets/e2b303b9-a74e-4939-9d5d-6e0f50b46941" width="49%" height="280"/>

</div>

+ 공중적- 레이저 공격
+ 지상적- 총알 공격 , 순간 빠른 속도로 이동


#### 엔딩
<img src="https://github.com/user-attachments/assets/04ec79d1-8c07-4b55-b1f4-5a899eb42117" width="49%" height="280"/>

+ 모든 적을 물리치면 생성
+ 스페이스 스톤 획득 시 씬 전환, 다음 스테이지 잠금 해제 

<br>

## 6. 기술 문서( 담당한 핵심기능 코드 포함)
+ https://docs.google.com/presentation/d/1T0axGK3wXZ9rHkEpkYmO2pyhAodyl-_pG6aENf-RMZU/edit?hl=ko#slide=id.g2f0c2aa774c_0_13

## 7. 티스토리 개발일지
+ https://syyeom1002.tistory.com/category/%EB%A7%88%EB%B8%94%20VR%20%ED%94%84%EB%A1%9C%EC%A0%9D%ED%8A%B8%20%EC%A0%9C%EC%9E%91


## 8. 플레이 영상
+ https://www.youtube.com/watch?v=FLcZElzEC0A&t
+ 타이틀씬부터 다음 스테이지 잠금 해제 부분까지 전체적인 구현을 보실 수 있습니다.

---

**담당한 부분(작성한 스크립트)**

짝수 Step 구현 (2,4,6,8,10,12)
