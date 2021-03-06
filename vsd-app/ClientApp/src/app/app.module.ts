import { BrowserModule, Title } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';
import { CookieService } from 'ngx-cookie-service';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {
  MatAutocompleteModule,
  MatButtonModule,
  MatButtonToggleModule,
  MatCardModule,
  MatCheckboxModule,
  MatChipsModule,
  MatDatepickerModule,
  MatDialogModule,
  MatDividerModule,
  MatExpansionModule,
  MatGridListModule,
  MatIconModule,
  MatInputModule,
  MatListModule,
  MatMenuModule,
  MatNativeDateModule,
  MatPaginatorModule,
  MatProgressBarModule,
  MatProgressSpinnerModule,
  MatRadioModule,
  MatRippleModule,
  MatSelectModule,
  MatSidenavModule,
  MatSliderModule,
  MatSlideToggleModule,
  MatSnackBarModule,
  MatSortModule,
  MatStepperModule,
  MatTableModule,
  MatTabsModule,
  MatToolbarModule,
  MatTooltipModule
} from '@angular/material';
import { CdkTableModule } from '@angular/cdk/table';
import { JusticeApplicationDataService } from './services/justice-application-data.service';
import { AppComponent } from './app.component';
import { BreadcrumbComponent } from './breadcrumb/breadcrumb.component';
import { CanDeactivateGuard } from './services/can-deactivate-guard.service';
import { StaticComponent } from './static/static.component';
import { HomeComponent } from './home/home.component';
import { VersionInfoDataService } from './services/version-info-data.service';
import { NotFoundComponent } from './not-found/not-found.component';
import { AddressComponent } from './shared/address/address.component';
import { SignPadDialog } from './sign-dialog/sign-dialog.component';
import { SummaryOfBenefitsDialog } from './summary-of-benefits/summary-of-benefits.component';
import { CancelApplicationDialog } from './shared/cancel-dialog/cancel-dialog.component';
import { DeactivateGuardDialog } from './shared/guard-dialog/guard-dialog.component';
import { VictimApplicationComponent } from './victim-application/victim-application.component';
import { IfmApplicationComponent } from './ifm-application/ifm-application.component';
import { WitnessApplicationComponent } from './witness-application/witness-application.component';
import { ApplicationSuccessComponent } from './application-success/application-success.component';
import { ApplicationCancelledComponent } from './application-cancelled/application-cancelled.component';
import { SubmitInvoiceComponent } from './submit-invoice/submit-invoice.component';
import { VictimRestitutionComponent } from './victim-restitution/victim-restitution.component';
import { VictimRestitutionReviewComponent } from './victim-restitution/victim-restitution-review.component';
import { OffenderRestitutionComponent } from './offender-restitution/offender-restitution.component';
import { OffenderRestitutionReviewComponent } from './offender-restitution/offender-restitution-review.component';
import { FileDropModule } from 'ngx-file-drop';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { FileUploaderComponent } from './shared/file-uploader/file-uploader.component';
import { NgBusyModule } from 'ng-busy';
import { BsDatepickerModule, AlertModule, BsDropdownModule } from 'ngx-bootstrap';
import { TermsAndConditionsComponent } from './lite/terms-and-conditions/terms-and-conditions.component';
import { AliasDataService } from './services/alias-data.service';
import { FieldComponent } from './shared/field/field.component';
import { QuickExitComponent } from './quick-exit/quick-exit.component';
import { ToolTipTriggerComponent } from './shared/tool-tip/tool-tip.component';
import { VersionInfoDialog } from './version-info/version-info.component';
import { SignaturePadModule } from 'angular2-signaturepad';
import { TestComponent } from './test/test.component';
import { FileUploaderBoxComponent } from './file-uploader-box/file-uploader-box.component';
// import { EmploymentIncomeComponent } from './employment-income/employment-income.component';
import { NameBlockComponent } from './name-block/name-block.component';
import { DatePickerComponent } from './date-picker/date-picker.component';
import { FilenameBlockComponent } from './filename-block/filename-block.component';
import { PhonePipe } from './pipes/phone.pipe';
import { NgxMaskModule } from 'ngx-mask'
import { CrimeInformationComponent } from './shared/crime-information/crime-information.component';
import { AuthorizationInformationComponent } from './shared/authorization-information/authorization-information.component';
import { MedicalInformationComponent } from './shared/medical-information/medical-information.component';
import { VictimInformationComponent } from './shared/victim-information/victim-information.component';
import { PersonalInformationComponent } from './shared/personal-information/personal-information.component';
import { RepresentativeInformationComponent } from './shared/representative-information/representative-information.component';
import { IntroductionComponent } from './shared/introduction/introduction.component';
import { DeclarationInformationComponent } from './shared/declaration-information/declaration-information.component';
import { ExpenseInformationComponent } from './shared/expense-information/expense-information.component';
import { ApplicationReviewComponent } from './shared/application-review/application-review.component';
import { EmploymentInformationComponent } from './shared/employment-information/employment-information.component';
import { CancelDialog } from './shared/dialogs/cancel/cancel.dialog';
import { InvoiceInstructionsDialog } from './shared/dialogs/invoice-instructions/invoice-instructions.dialog';
import { StateService } from './services/state.service';

@NgModule({
  declarations: [
    AppComponent,
    AddressComponent,
    SignPadDialog,
    SummaryOfBenefitsDialog,
    CancelApplicationDialog,
    CancelDialog,
    DeactivateGuardDialog,
    VictimApplicationComponent,
    IfmApplicationComponent,
    WitnessApplicationComponent,
    ApplicationSuccessComponent,
    ApplicationCancelledComponent,
    SubmitInvoiceComponent,
    VictimRestitutionComponent,
    VictimRestitutionReviewComponent,
    OffenderRestitutionComponent,
    OffenderRestitutionReviewComponent,
    CrimeInformationComponent,
    MedicalInformationComponent,
    AuthorizationInformationComponent,
    BreadcrumbComponent,
    HomeComponent,
    NotFoundComponent,
    StaticComponent,
    FileUploaderComponent,
    FieldComponent,
    QuickExitComponent,
    ToolTipTriggerComponent,
    TermsAndConditionsComponent,
    ApplicationReviewComponent,
    VersionInfoDialog,
    TestComponent,
    FileUploaderBoxComponent,
    InvoiceInstructionsDialog,
    EmploymentInformationComponent,
    VictimInformationComponent,
    PersonalInformationComponent,
    RepresentativeInformationComponent,
    IntroductionComponent,
    DeclarationInformationComponent,
    ExpenseInformationComponent,
    NameBlockComponent,
    DatePickerComponent,
    FilenameBlockComponent,
    PhonePipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgBusyModule,
    CdkTableModule,
    MatAutocompleteModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatDatepickerModule,
    MatDialogModule,
    MatDividerModule,
    MatExpansionModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatStepperModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    MatTooltipModule,
    FileDropModule,
    SignaturePadModule,
    //IntlTelInputNgModule.forRoot(),
    //NgxIntlTelInputModule,
    TooltipModule.forRoot(),
    //    BsDropdownModule.forRoot(),
    BsDatepickerModule.forRoot(),
    AlertModule.forRoot(),
    NgxMaskModule.forRoot(),
  ],
  exports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    CdkTableModule,
    MatAutocompleteModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatDatepickerModule,
    MatDialogModule,
    MatDividerModule,
    MatExpansionModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatStepperModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    FileDropModule,
    TooltipModule,
    MatTooltipModule
  ],
  providers: [
    CrimeInformationComponent,
    CookieService,
    CanDeactivateGuard,
    AliasDataService,
    JusticeApplicationDataService,
    Title,
    VersionInfoDataService,
    StateService,
  ],
  entryComponents: [
    VersionInfoDialog,
    SignPadDialog,
    SummaryOfBenefitsDialog,
    CancelApplicationDialog,
    CancelDialog,
    DeactivateGuardDialog,
    InvoiceInstructionsDialog
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
