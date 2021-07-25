classdef mynb
    methods(Static)
        
        % Summary
        
        % The training data for Naive Bayes uses the normal distribution 
        % (probability density can never be zero, bell curve stretches to 
        % infinity) to model the variation of each feature value (Z score 
        % standardisation is unnessessary) meaning that values far from the
        % average are unlikly thogh not impossible.
        % Naive bayes makes the assuption that all features in the dataset 
        % are equally important and independant (class-condiditonal), 
        % we assume a dependancey between class label and feature values. 
        
        % The training process for Naive Bayes takes the taining data and
        % works out the probability densities (Expaneded on below) for different 
        % possible classes. Prior probability is calculated by dividing the
        % number of times that a class occurss in the training data by the
        % number of training examples.
        % The size of the training data dosnt effect the
        % speed of evaluating testing data though will effect the training
        % phase. Evaluating and multiplying probablity densities will take
        % the same amount of time reagardless of the amount of training
        % data.
        
        % Testing phase estimates the likelyhood of a new example belonging
        % to a given class by calculating the probability density for each
        % feature value separately and then multiplying the answers together.
        % When testing the current data is compaired to the training data
        % and a probability that it is the same class as each training example
        % is calcuculated, the current data is then given the class as the
        % example with the highest probiblity of being the same.
        % To classify 10 new testing examples that belong to 5 different
        % classes with 10 feature values and 100 training examples will
        % require (((5*10)*10)==((every class*every feat)*every new example
        % ))) 500 calculations. The
        % majority of calculations are done at the training phase
        %(likelyhood*prior= proportional to posterior prob).
        

        function m = fit(train_examples, train_labels)
            
            % Finds each unique class label
            m.unique_classes = unique(train_labels);
            % Finds the number of unique classes
            m.n_classes = length(m.unique_classes);

            m.means = {};
            m.stds = {};
            
            % Probability density 
            % i = number of unique classes
            for i = 1:m.n_classes
                
                % Set up this_class variable 
				this_class = m.unique_classes(i);
                % Finds all the examples of this class and then calculates
                % the mean and standard deciation of all of the feature
                % values
                examples_from_this_class = train_examples{train_labels==this_class,:};
                m.means{end+1} = mean(examples_from_this_class);
                m.stds{end+1} = std(examples_from_this_class);
            
            end
            

            m.priors = [];
            % A prior is the probibility an estimate of how likely each 
            % class label is to occur, based on how many times it is 
            % present in the training data. 
            
            for i = 1:m.n_classes
                % this loop pulls all training exampes wich belong to the
                % current class and then calculates the number of examples
                % from the cuurent class as a fraction of the total, to
                % give a probability that another randmly chosen will
                % belong to this class
				this_class = m.unique_classes(i);
                examples_from_this_class = train_examples{train_labels==this_class,:};
                m.priors(end+1) = size(examples_from_this_class,1) / size(train_labels,1);
            
			end

        end

        function predictions = predict(m, test_examples)

            predictions = categorical;

            for i=1:size(test_examples,1)
                % This loop cycles through all of the test examples and
                % cals the predict one function
				fprintf('classifying example %i/%i\n', i, size(test_examples,1));
                this_test_example = test_examples{i,:};
                this_prediction = mynb.predict_one(m, this_test_example);
                predictions(end+1) = this_prediction;
            
			end
        end

        function prediction = predict_one(m, this_test_example)
            % Loops over all the possible class labels then for each,
            % calculates a likelihood for the current test example given
            % the class.  It then computes a value which is proportional
            % to the posterior: the probability of the current class label,
            % given the test example by multiplying the current calculation
            % with the prior
            for i=1:m.n_classes

				this_likelihood = mynb.calculate_likelihood(m, this_test_example, i);
                this_prior = mynb.get_prior(m, i);
                posterior_(i) = this_likelihood * this_prior;
            
            end
            % beacuse the values stored in posterior ane proportional to
            % the true posterieo probablilitys, the most likly class lable
            % is the wone with the highest probiblity stored this is
            % accessed using hte max()
            [winning_value_, winning_index] = max(posterior_);
            prediction = m.unique_classes(winning_index);

        end
        
        % checks the values of every feature in isolation
        function likelihood = calculate_likelihood(m, this_test_example, class)
            
			likelihood = 1;
            
			for i=1:length(this_test_example)
                likelihood = likelihood * mynb.calculate_pd(this_test_example(i), m.means{class}(i), m.stds{class}(i));
            end
        end
        
        function prior = get_prior(m, class)
            
			prior = m.priors(class);
        
		end
        
        function pd = calculate_pd(x, mu, sigma)
        
			first_bit = 1 / sqrt(2*pi*sigma^2);
            second_bit = - ( ((x-mu)^2) / (2*sigma^2) );
            pd = first_bit * exp(second_bit);
        
		end
            
    end
end