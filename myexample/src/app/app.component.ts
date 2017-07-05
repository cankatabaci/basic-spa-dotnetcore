import { Component } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';

@Component({
  selector: 'app-component',
  templateUrl: './app.component.html',
  moduleId: module.id,
})
export class AppComponent {
    successMessage: string = '';
    title = 'calisiyor!';
    constructor(
        private http: Http
          ) {

    }

    executePost(): Promise<any> {
        var promise = this.http.post("http://localhost:5000/Home/PostEx", null)
            .toPromise()
            .then(
            function Success(response) {
                return response.json();
            }
            );
        return promise;
    }

    onClick() {
        var promise = this.executePost();
        promise.then(response => this.onClickSuccess(response));
    }

    onClickSuccess(response: string) {
        this.successMessage = response;
    }
}
