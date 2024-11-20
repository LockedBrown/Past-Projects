import numpy as np
from PIL import ImageGrab
import cv2
import time
import pyautogui

face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')
eye_cascade = cv2.CascadeClassifier('haarcascade_eye.xml')
fullbody_cascade = cv2.CascadeClassifier('haarcascade_fullbody.xml')

while True:
        
    screen = np.array(ImageGrab.grab(bbox=(112, 228, 1255, 873)))
    screen = cv2.cvtColor(screen, cv2.COLOR_BGR2RGB)
    gray = cv2.cvtColor(screen, cv2.COLOR_BGR2GRAY)

    # bodys = fullbody_cascade.detectMultiScale(gray, 1.3, 5)
    # for (bx, by, bw, bh) in bodys:
    #     cv2.rectangle(screen, (bx, by), (bx+bw, by+bh), (255, 0, 0), 2)
    #     roi_gray = gray[by: by+bh, bx:bx+bw]
    #     roi_color = screen[by:by+bh, bx:bx+bw]  
    faces = face_cascade.detectMultiScale(gray, 1.3, 5)
    for (fx,fy,fw,fh) in faces:
        cv2.rectangle(screen, (fx, fy), (fx+fw, fy+fh), (255, 0, 0), 2)
        roi_gray = gray[fy: fy+fh, fx:fx+fw]
        roi_color = screen[fy:fy+fh, fx:fx+fw]
        eyes = eye_cascade.detectMultiScale(roi_gray)
        for (ex, ey, ew, eh) in eyes:
            cv2.rectangle(roi_color, (ex, ey), (ex + ew, ey + eh), (0, 255, 0), 2)

    cv2.imshow('Facial Detection', screen)
    if cv2.waitKey(25) == ord('q'):
        break
cv2.destroyAllWindows()

