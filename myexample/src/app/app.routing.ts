import { Routes, RouterModule } from '@angular/router';

import { HastaEkleComponent } from './hastaEkle/hastaEkle.component';
import { HastaListeleComponent } from './hastaListele/hastaListele.component';

const app_routes: Routes = [
  { path: '', pathMatch:'full', redirectTo: '' },
  { path: 'hastaEkle', component: HastaEkleComponent    },
  { path: 'hastaListele', component: HastaListeleComponent },
];


export const app_routing = {
  routes: RouterModule.forRoot(app_routes),
  components: [     
                HastaEkleComponent, HastaListeleComponent
              ]
};