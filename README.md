# Automated-Guided-Vehicle-Warehouse-Management-System

### <소개>
공정에서 나온 물건을 라인트레이서로 창고에 옮기고 실시간으로 창고상태, 라인트레이서 상태 등을 GUI로 확인.
3명이 팀으로 저의 역할은 C#으로 GUI구현, DB와 연동입니다.

### <제작 기간>
2018-12-01 ~ 2018-12-28

### <라인트레이서 디자인>
![image](https://user-images.githubusercontent.com/42165236/50536183-072e0580-0b95-11e9-9b43-700f1b460136.png)

### <C#화면 디자인>
![image](https://user-images.githubusercontent.com/42165236/50536353-de0e7480-0b96-11e9-8064-7880bbfd8bd0.png)
![image](https://user-images.githubusercontent.com/42165236/50536351-d058ef00-0b96-11e9-90c6-31b0c427dd98.png)
![image](https://user-images.githubusercontent.com/42165236/50536353-de0e7480-0b96-11e9-8064-7880bbfd8bd0.png)


### <시스템 구성도>
![image](https://user-images.githubusercontent.com/42165236/50536292-2b3e1680-0b96-11e9-9a95-b0f5e4696092.png)

### <프로젝트를 하며 느낀점...>
 첫째로 현재 사용하고 있는 모듈인 esp-01은 esp8266모듈 중에서 성능이 가장 낮은 모듈이었습니다. 이 모듈을 사용해 통신하기 위해 아두이노에서 송출한 데이터를 php에서 받고 그것을 다시 라즈베리파이 데이터베이스에 보내는 방법을 사용하였습니다. 아두이노에서 송신한 데이터를 데이터베이스에 직접 보내는 것이 원래의 목적이어서 아쉬웠던 부분입니다. Wifi쉴드를 장착한 아두이노를 데이터 송신용으로 따로 두거나, 더 좋은 모듈을 쓴다면, 개발이 더 쉬워질 것입니다.
 
 둘째로 처음에 RC-Car를 움직일 때 사용한 전압은 1.5V 건전지 6개와 9V 건전지 1개를 각각 모터드라이브와 아두이노에 인가하였습니다. 시험을 거듭할수록 모터의 힘이 눈에 띄게 낮아지고, 그 전력만으로는 나중에 장착할 서보모터나 초음파센서를 다룰 수 없었습니다. 현재 사용하고 있는 모터드라이버의 허용 전압은 35V입니다. 건전지를 7V AA사이즈의 리튬 건전지를 사용하였으면, 힘이 부족하여 RC-Car가 동작하지 않을 일은 없었을 것이라 생각합니다.

### <시연 영상>
Link: [Google][googlelink] [googlelink]: https://google.com "Go google"
