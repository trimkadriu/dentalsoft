﻿using DentalSoft.Domain;
using DentalSoft.Library;
using DentalSoft.Repositories;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DentalSoft.Service
{
    public class DentistService
    {
        private DentistsRepository dentistsRepository;
        private Validators validators;

        public DentistService()
        {
            dentistsRepository = new DentistsRepository();
            validators = new Validators();
        }

        public bool editDentist(Dentist dentist)
        {
            List<Dentist> dentists = dentistsRepository.selectStatement(null, null, dentist.getEmail());
            if (dentists.Count == 1 && !dentists[0].getPerdoruesi().Equals(dentist.getPerdoruesi()))
            {
                MessageBox.Show("Ky email eshte duke u perdorur. Ju lutem zgjedhni email tjeter.", "Gabim!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
                dentistsRepository.updateStatement(dentist);
            return true;
        }

        public bool insertDentist(Dentist dentist)
        {
            if (!validators.isValidEmail(dentist.getEmail()))
            {
                MessageBox.Show("Email-i nuk eshte valid. Ju lutem shkruani emailin ne forme te rregullt.", "Gabim!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            List<Dentist> dentistsByEmail = dentistsRepository.selectStatement(null, null, dentist.getEmail());
            if (dentistsByEmail.Count == 1)
            {
                MessageBox.Show("Ky email eshte duke u perdorur. Ju lutem zgjedhni email tjeter.", "Gabim!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            List<Dentist> dentistsByPerdoruesi = dentistsRepository.selectStatement(null, null, null, dentist.getPerdoruesi());
            if (dentistsByPerdoruesi.Count == 1)
            {
                MessageBox.Show("Ky emer i perdoruesit (per qasje) eshte duke u perdorur. Ju lutem zgjedhni emer tjeter.", "Gabim!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            dentistsRepository.insertStatement(dentist);
            return true;
        }

        public List<Dentist> getAllDentists()
        {
            List<Dentist> dentists = dentistsRepository.selectStatement();
            return dentists;
        }
    }
}
