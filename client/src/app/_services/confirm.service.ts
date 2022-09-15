import { Injectable } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Injectable({
  providedIn: 'root'
})
export class ConfirmService {
  bsModalRef: BsModalRef

  constructor(private modalService: BsModalService) { }

  confirm(
    title = 'Confirmation', 
    message = "Czy jesteś pewien aby to zrobić?", 
    btnOkText = 'Di', 
    btnCancelText = 'Noł') {
      const config = {
        initialState: {
          title,
          message,
          btnOkText,
          btnCancelText,
        }
      }
      this.bsModalRef = this.modalService.show('confirm', config)
  }
}
