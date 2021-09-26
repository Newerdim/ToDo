import {Component, OnInit} from '@angular/core';
import {ModalService} from '../../services/modal.service';
import {ModalId} from "../../enums/ModalId";

@Component({
  selector: 'app-sign-up-modal',
  templateUrl: './sign-up-modal.component.html',
  styleUrls: ['./sign-up-modal.component.scss']
})
export class SignUpModalComponent implements OnInit {

  constructor(private modalService: ModalService) {
  }

  ngOnInit(): void {
  }

  hideModal(): void {
    this.modalService.hide(ModalId.SignUp);
  }

  showLogInModal(): void {
    this.modalService.hideAll();
    this.modalService.show(ModalId.LogIn)
  }
}
