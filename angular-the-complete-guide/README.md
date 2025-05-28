# Angular - The Complete Guide

Official site: https://angular.io/

Udemy Course: https://www.udemy.com/course/the-complete-guide-to-angular-2/

---

|Number|Commands                                                                |Description                |
|--|--                                                                          |--                         |
|1.|npm install -g @angular/cli                                                 |Install Angular CLI        |
|2.|ng new first-app --no-strict --standalone false --routing false             |Create first project       |
||cd my-first-app                                                               |Go to the project          |
||ng serve                                                                      |Run the Angular project    |
||npm install --save bootstrap@3                                                |Run the Angular project    |


Create first component:
ng g c recipes --skip-tests
ng g c recipes/recipe-list --skip-tests
ng g c recipes/recipe-detail --skip-tests
ng g c recipes/recipe-item --skip-tests
ng g c shopping-list --skip-tests
ng g c shopping-list/shopping-edit --skip-tests
ng g c cockpit --skip-tests
ng g c server-element --skip-tests

ng g c shoping-list --skip-tests


---

In order to follow along smoothly with the course examples, make sure you install RxJS v6 by running

npm install --save rxjs@6
In addition, also install the rxjs-compat package:

npm install --save rxjs-compat


